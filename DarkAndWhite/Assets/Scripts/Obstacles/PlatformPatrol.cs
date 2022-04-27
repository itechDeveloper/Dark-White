using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPatrol : MonoBehaviour
{
    public float speed;
    public float distance;

    private bool movingRight = true;

    public Transform groundDetection;
    public Transform groundExists;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * (speed) * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        RaycastHit2D rayGroundExists = Physics2D.Raycast(groundExists.position, Vector2.down, distance);

        if (rayGroundExists.collider) {
            transform.parent = rayGroundExists.collider.gameObject.transform;
        }

        if (groundInfo.collider == false && rayGroundExists.collider == true)
        {
            if (movingRight)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }
        else if (groundInfo.collider == false && rayGroundExists.collider == false)
        {
            Destroy(gameObject);
        }
    }
}
