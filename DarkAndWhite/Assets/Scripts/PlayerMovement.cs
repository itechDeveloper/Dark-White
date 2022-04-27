using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public AudioSource jumpsesi;
    public AudioSource dashsesi;
    public Rigidbody2D rb;
    public TouchController touchController;
        
    //Player movement begin
    internal float xMov;
    public float speed;

    bool facingRight = true;
    //Player movement end

    //Jump begin
    public float jumpVelocity;
    internal bool isJumping;
    internal bool isLanding;
 
    internal bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;

    public bool canJump;
    //jump end
    
    //Dust effect begin
    public ParticleSystem dust;
    private bool dustPlayed;
    private float dustPlayTime;
    private float startDustPlayTime = 0.1f;
    //Dust effect end   

    //Dash begin
    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    internal int direction;
    internal bool canDash;

    internal float dashTimeCoolDown;
    public float startDashTimeCoolDown;

    public CameraShake cameraShake;
    public Ghost ghost;
    //Dash end

    public bool barrier;

    internal int firstTime = 0;

    //Death
    public Clock clock;
    public Health health;
    public GameObject deathParticle;
    public GameObject deathParticleBlack;

    public CapsuleCollider2D capsuleCollider;
    void Start()
    {
        firstTime = PlayerPrefs.GetInt("firstTime");
        if (firstTime == 0)
        {
            PlayerPrefs.SetFloat("JumpVelocity",10f);
            PlayerPrefs.SetFloat("Speed", 6f);
            PlayerPrefs.SetFloat("DashSpeed", 21f);
            PlayerPrefs.SetFloat("DashCoolDown", 2.5f);
            firstTime += 1;
            PlayerPrefs.SetInt("firstTime", firstTime);
        }

        rb = GetComponent<Rigidbody2D>();

        jumpVelocity = PlayerPrefs.GetFloat("JumpVelocity");
        speed = PlayerPrefs.GetFloat("Speed");
        dashSpeed = PlayerPrefs.GetFloat("DashSpeed");
        startDashTimeCoolDown = PlayerPrefs.GetFloat("DashCoolDown");
    }

    private void FixedUpdate()
    {
        Movement();
        Flip();
        Dash();
        KillPlayer();
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
        Jump();
    }

    void Movement()
    {
        //xMov = Input.GetAxisRaw("Horizontal");
        xMov = touchController.offset.x;
        if (xMov > 0.3f)
        {
            xMov = 1;
        }else if (xMov < -0.3f)
        {
            xMov = -1;
        }
        else
        {
            xMov = 0;
        }
        rb.velocity = new Vector2(xMov * speed, rb.velocity.y);
    }

    void Flip()
    {
        if (xMov < 0 && facingRight)
        {
            facingRight = !facingRight;
            transform.Rotate(0, 180, 0);
        }else if (xMov > 0 && !facingRight)
        {
            facingRight = !facingRight;
            transform.Rotate(0, 180, 0);
        }
    }

    void Jump() 
    {
        if (isGrounded && Input.GetMouseButtonDown(0) && touchController.pointA.x > (Camera.main.transform.position.x / 2))
        {
            isJumping = true;
            jumpsesi.Play();
            rb.velocity = new Vector2(rb.velocity.x, jumpVelocity);
            CreateDust();
            dustPlayed = false;
            dustPlayTime = startDustPlayTime;
        }

        else if (isGrounded && Input.GetMouseButtonDown(1) && touchController.pointC.x > (Camera.main.transform.position.x / 2))
        {
            isJumping = true;
            jumpsesi.Play();
            rb.velocity = new Vector2(rb.velocity.x, jumpVelocity);
            CreateDust();
            dustPlayed = false;
            dustPlayTime = startDustPlayTime;
        }

        if (Input.GetMouseButtonUp(0))
        {
            isJumping = false;
        }

        if (Input.GetMouseButtonUp(1))
        {
            isJumping = false;
        }

        if (isGrounded && !dustPlayed)
        {
            if (dustPlayTime <= 0) {
                dustPlayed = true;

            } else if (dustPlayTime > 0)
            {
                CreateDust();
                dustPlayTime -= Time.deltaTime;
            }
        }
    }

    void CreateDust()
    {
        dust.Play();
    }

    void Dash()
    {
        if (dashTimeCoolDown > 0)
        {
            dashTimeCoolDown -= Time.deltaTime;
        }

        if (direction == 0)
        {
            ghost.makeGhost = false;
            if (xMov < 0 && canDash)
            {
                direction = 1;
                dashTimeCoolDown = startDashTimeCoolDown;
            }
            if (xMov > 0 && canDash)
            {
                direction = 2;
                dashTimeCoolDown = startDashTimeCoolDown;
            }
            if (xMov == 0 && canDash)
            {
                direction = 3;
                dashTimeCoolDown = startDashTimeCoolDown;
            }
        }
        else
        {
            ghost.makeGhost = true;
            StartCoroutine(cameraShake.Shake(.2f, .15f));
            if(direction == 3)
            {
                dashsesi.Play();
                ghost.makeGhost = true;
                rb.velocity = Vector2.up * (jumpVelocity * 1.2f);
                canDash = false;
                direction = 0;
                dashTime = startDashTime;
            }
            else if (dashTime <= 0)
            {
                direction = 0;
                dashTime = startDashTime;
                rb.velocity = Vector2.zero;
            }
            else
            {
                dashTime -= Time.deltaTime;

                if (direction == 1)
                {
                    dashsesi.Play();
                    rb.velocity = Vector2.left * dashSpeed;
                    canDash = false;
                }
                else if (direction == 2)
                {
                    dashsesi.Play();
                    rb.velocity = Vector2.right * dashSpeed;
                    canDash = false;
                }
            }
        }
    }

    void KillPlayer()
    {
        if (health.health <= 0)
        {
            if (!clock.white)
            {
                Instantiate(deathParticle, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
            else if (clock.white)
            {
                Instantiate(deathParticleBlack, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
            Instantiate(deathParticle,transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
    
        if (other.gameObject.CompareTag("WhitePlatform"))
        {
            this.transform.parent = other.transform;
        }
    
        if (other.gameObject.CompareTag("BlackPlatform"))
        {
            this.transform.parent = other.transform;
        }
    }
    
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("WhitePlatform"))
        {
            this.transform.parent = null;
        }
    
        if (other.gameObject.CompareTag("BlackPlatform"))
        {
            this.transform.parent = null;
        }
    }
}
