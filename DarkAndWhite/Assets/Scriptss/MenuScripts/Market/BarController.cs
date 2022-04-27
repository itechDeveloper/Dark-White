using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarController : MonoBehaviour
{
    
    public int kontrolspeed;
    public int kontroldash;

    public GameObject speedbar1;
    public GameObject speedbar2;
    public GameObject speedbar3;
    public GameObject speedbar0;
    public GameObject speedbare1;
    public GameObject speedbare2;
    public GameObject speedbare3;
    public GameObject jumpbar1;
    public GameObject jumpbar2;
    public GameObject jumpbar3;
    public GameObject jumpbar0;
    public GameObject jumpbare1;
    public GameObject jumpbare2;
    public GameObject jumpbare3;
    public GameObject dashbar1;
    public GameObject dashbar2;
    public GameObject dashbar3;
    public GameObject dashbar0;
    public GameObject dashbare1;
    public GameObject dashbare2;
    public GameObject dashbare3;
    public GameObject dashdownbar1;
    public GameObject dashdownbar2;
    public GameObject dashdownbar3;
    public GameObject dashdownbar0;
    public GameObject dashdownbare1;
    public GameObject dashdownbare2;
    public GameObject dashdownbare3;

    public GameObject speedup1;
    public GameObject speedup2;
    public GameObject speedup3;
    public GameObject speedup4;
    public GameObject jump1;
    public GameObject jump2;
    public GameObject jump3;
    public GameObject jump4;
    public GameObject dashup1;
    public GameObject dashup2;
    public GameObject dashup3;
    public GameObject dashup4;
    public GameObject dashdown1;
    public GameObject dashdown2;
    public GameObject dashdown3;
    public GameObject dashdown4;


    // Update is called once per frame
    void Update()
    {
        kontrolspeed = PlayerPrefs.GetInt("kontrolSpeed");
        kontroldash = PlayerPrefs.GetInt("kontrolDash");

         if(kontrolspeed == 0)
        {
            jumpbar0.gameObject.SetActive(true);
            jumpbar1.gameObject.SetActive(false);
            jumpbar2.gameObject.SetActive(false);
            jumpbar3.gameObject.SetActive(false);
            jumpbare1.gameObject.SetActive(false);
            jumpbare2.gameObject.SetActive(false);
            jumpbare3.gameObject.SetActive(false);
            speedbar0.gameObject.SetActive(true);
            speedbar1.gameObject.SetActive(false);
            speedbar2.gameObject.SetActive(false);
            speedbar3.gameObject.SetActive(false);
            speedbare1.gameObject.SetActive(false);
            speedbare2.gameObject.SetActive(false);
            speedbare3.gameObject.SetActive(false);

            speedup1.gameObject.SetActive(true);
            speedup2.gameObject.SetActive(false);
            speedup3.gameObject.SetActive(false);
            speedup4.gameObject.SetActive(false);
            jump1.gameObject.SetActive(true);
            jump2.gameObject.SetActive(false);
            jump3.gameObject.SetActive(false);
            jump4.gameObject.SetActive(false);


        }

         else if (kontrolspeed == 1)
        {
            jumpbar0.gameObject.SetActive(false);
            jumpbar1.gameObject.SetActive(false);
            jumpbar2.gameObject.SetActive(false);
            jumpbar3.gameObject.SetActive(false);
            jumpbare1.gameObject.SetActive(true);
            jumpbare2.gameObject.SetActive(false);
            jumpbare3.gameObject.SetActive(false);
            speedbar0.gameObject.SetActive(false);
            speedbar1.gameObject.SetActive(true);
            speedbar2.gameObject.SetActive(false);
            speedbar3.gameObject.SetActive(false);
            speedbare1.gameObject.SetActive(false);
            speedbare2.gameObject.SetActive(false);
            speedbare3.gameObject.SetActive(false);

            speedup1.gameObject.SetActive(false);
            speedup2.gameObject.SetActive(true);
            speedup3.gameObject.SetActive(false);
            speedup4.gameObject.SetActive(false);
            jump1.gameObject.SetActive(true);
            jump2.gameObject.SetActive(false);
            jump3.gameObject.SetActive(false);
            jump4.gameObject.SetActive(false);



        }

        else if (kontrolspeed == 2)
        {
            jumpbar0.gameObject.SetActive(false);
            jumpbar1.gameObject.SetActive(false);
            jumpbar2.gameObject.SetActive(false);
            jumpbar3.gameObject.SetActive(false);
            jumpbare1.gameObject.SetActive(false);
            jumpbare2.gameObject.SetActive(true);
            jumpbare3.gameObject.SetActive(false);
            speedbar0.gameObject.SetActive(false);
            speedbar1.gameObject.SetActive(false);
            speedbar2.gameObject.SetActive(true);
            speedbar3.gameObject.SetActive(false);
            speedbare1.gameObject.SetActive(false);
            speedbare2.gameObject.SetActive(false);
            speedbare3.gameObject.SetActive(false);
            
            speedup1.gameObject.SetActive(false);
            speedup2.gameObject.SetActive(false);
            speedup3.gameObject.SetActive(true);
            speedup4.gameObject.SetActive(false);
            jump1.gameObject.SetActive(true);
            jump2.gameObject.SetActive(false);
            jump3.gameObject.SetActive(false);
            jump4.gameObject.SetActive(false);



        }

        else if (kontrolspeed == 3)
        {
            jumpbar0.gameObject.SetActive(false);
            jumpbar1.gameObject.SetActive(false);
            jumpbar2.gameObject.SetActive(false);
            jumpbar3.gameObject.SetActive(false);
            jumpbare1.gameObject.SetActive(false);
            jumpbare2.gameObject.SetActive(false);
            jumpbare3.gameObject.SetActive(true);
            speedbar0.gameObject.SetActive(false);
            speedbar1.gameObject.SetActive(false);
            speedbar2.gameObject.SetActive(false);
            speedbar3.gameObject.SetActive(true);
            speedbare1.gameObject.SetActive(false);
            speedbare2.gameObject.SetActive(false);
            speedbare3.gameObject.SetActive(false);

            speedup1.gameObject.SetActive(false);
            speedup2.gameObject.SetActive(false);
            speedup3.gameObject.SetActive(false);
            speedup4.gameObject.SetActive(true);
            jump1.gameObject.SetActive(true);
            jump2.gameObject.SetActive(false);
            jump3.gameObject.SetActive(false);
            jump4.gameObject.SetActive(false);

        }

        else if (kontrolspeed == -1)
        {
            jumpbar0.gameObject.SetActive(false);
            jumpbar1.gameObject.SetActive(true);
            jumpbar2.gameObject.SetActive(false);
            jumpbar3.gameObject.SetActive(false);
            jumpbare1.gameObject.SetActive(false);
            jumpbare2.gameObject.SetActive(false);
            jumpbare3.gameObject.SetActive(false);
            speedbar0.gameObject.SetActive(false);
            speedbar1.gameObject.SetActive(false);
            speedbar2.gameObject.SetActive(false);
            speedbar3.gameObject.SetActive(false);
            speedbare1.gameObject.SetActive(true);
            speedbare2.gameObject.SetActive(false);
            speedbare3.gameObject.SetActive(false);

            speedup1.gameObject.SetActive(true);
            speedup2.gameObject.SetActive(false);
            speedup3.gameObject.SetActive(false);
            speedup4.gameObject.SetActive(false);
            jump1.gameObject.SetActive(false);
            jump2.gameObject.SetActive(true);
            jump3.gameObject.SetActive(false);
            jump4.gameObject.SetActive(false);

        }

        else if (kontrolspeed == -2)
        {
            jumpbar0.gameObject.SetActive(false);
            jumpbar1.gameObject.SetActive(false);
            jumpbar2.gameObject.SetActive(true);
            jumpbar3.gameObject.SetActive(false);
            jumpbare1.gameObject.SetActive(false);
            jumpbare2.gameObject.SetActive(false);
            jumpbare3.gameObject.SetActive(false);
            speedbar0.gameObject.SetActive(false);
            speedbar1.gameObject.SetActive(false);
            speedbar2.gameObject.SetActive(false);
            speedbar3.gameObject.SetActive(false);
            speedbare1.gameObject.SetActive(false);
            speedbare2.gameObject.SetActive(true);
            speedbare3.gameObject.SetActive(false);

            speedup1.gameObject.SetActive(true);
            speedup2.gameObject.SetActive(false);
            speedup3.gameObject.SetActive(false);
            speedup4.gameObject.SetActive(false);
            jump1.gameObject.SetActive(false);
            jump2.gameObject.SetActive(false);
            jump3.gameObject.SetActive(true);
            jump4.gameObject.SetActive(false);

        }

        else if (kontrolspeed == -3)
        {
            jumpbar0.gameObject.SetActive(false);
            jumpbar1.gameObject.SetActive(false);
            jumpbar2.gameObject.SetActive(false);
            jumpbar3.gameObject.SetActive(true);
            jumpbare1.gameObject.SetActive(false);
            jumpbare2.gameObject.SetActive(false);
            jumpbare3.gameObject.SetActive(false);
            speedbar0.gameObject.SetActive(false);
            speedbar1.gameObject.SetActive(false);
            speedbar2.gameObject.SetActive(false);
            speedbar3.gameObject.SetActive(false);
            speedbare1.gameObject.SetActive(false);
            speedbare2.gameObject.SetActive(false);
            speedbare3.gameObject.SetActive(true);

            speedup1.gameObject.SetActive(true);
            speedup2.gameObject.SetActive(false);
            speedup3.gameObject.SetActive(false);
            speedup4.gameObject.SetActive(false);
            jump1.gameObject.SetActive(false);
            jump2.gameObject.SetActive(false);
            jump3.gameObject.SetActive(false);
            jump4.gameObject.SetActive(true);

        }

         if(kontroldash == 0)
        {
            dashbar0.gameObject.SetActive(true);
            dashbar1.gameObject.SetActive(false);
            dashbar2.gameObject.SetActive(false);
            dashbar3.gameObject.SetActive(false);
            dashbare1.gameObject.SetActive(false);
            dashbare2.gameObject.SetActive(false);
            dashbare3.gameObject.SetActive(false);
            dashdownbar0.gameObject.SetActive(true);
            dashdownbar1.gameObject.SetActive(false);
            dashdownbar2.gameObject.SetActive(false);
            dashdownbar3.gameObject.SetActive(false);
            dashdownbare1.gameObject.SetActive(false);
            dashdownbare2.gameObject.SetActive(false);
            dashdownbare3.gameObject.SetActive(false);

            dashup1.gameObject.SetActive(true);
            dashup2.gameObject.SetActive(false);
            dashup3.gameObject.SetActive(false);
            dashup4.gameObject.SetActive(false);
            dashdown1.gameObject.SetActive(true);
            dashdown2.gameObject.SetActive(false);
            dashdown3.gameObject.SetActive(false);
            dashdown4.gameObject.SetActive(false);
        }

         else if (kontroldash == 1)
        {
            dashbar0.gameObject.SetActive(false);
            dashbar1.gameObject.SetActive(true);
            dashbar2.gameObject.SetActive(false);
            dashbar3.gameObject.SetActive(false);
            dashbare1.gameObject.SetActive(false);
            dashbare2.gameObject.SetActive(false);
            dashbare3.gameObject.SetActive(false);
            dashdownbar0.gameObject.SetActive(false);
            dashdownbar1.gameObject.SetActive(false);
            dashdownbar2.gameObject.SetActive(false);
            dashdownbar3.gameObject.SetActive(false);
            dashdownbare1.gameObject.SetActive(true);
            dashdownbare2.gameObject.SetActive(false);
            dashdownbare3.gameObject.SetActive(false);


            dashup1.gameObject.SetActive(false);
            dashup2.gameObject.SetActive(true);
            dashup3.gameObject.SetActive(false);
            dashup4.gameObject.SetActive(false);
            dashdown1.gameObject.SetActive(true);
            dashdown2.gameObject.SetActive(false);
            dashdown3.gameObject.SetActive(false);
            dashdown4.gameObject.SetActive(false);
        }

        else if (kontroldash == 2)
        {
            dashbar0.gameObject.SetActive(false);
            dashbar1.gameObject.SetActive(false);
            dashbar2.gameObject.SetActive(true);
            dashbar3.gameObject.SetActive(false);
            dashbare1.gameObject.SetActive(false);
            dashbare2.gameObject.SetActive(false);
            dashbare3.gameObject.SetActive(false);
            dashdownbar0.gameObject.SetActive(false);
            dashdownbar1.gameObject.SetActive(false);
            dashdownbar2.gameObject.SetActive(false);
            dashdownbar3.gameObject.SetActive(false);
            dashdownbare1.gameObject.SetActive(false);
            dashdownbare2.gameObject.SetActive(true);
            dashdownbare3.gameObject.SetActive(false);


            dashup1.gameObject.SetActive(false);
            dashup2.gameObject.SetActive(false);
            dashup3.gameObject.SetActive(true);
            dashup4.gameObject.SetActive(false);
            dashdown1.gameObject.SetActive(true);
            dashdown2.gameObject.SetActive(false);
            dashdown3.gameObject.SetActive(false);
            dashdown4.gameObject.SetActive(false);
        }

        else if (kontroldash == 3)
        {
            dashbar0.gameObject.SetActive(false);
            dashbar1.gameObject.SetActive(false);
            dashbar2.gameObject.SetActive(false);
            dashbar3.gameObject.SetActive(true);
            dashbare1.gameObject.SetActive(false);
            dashbare2.gameObject.SetActive(false);
            dashbare3.gameObject.SetActive(false);
            dashdownbar0.gameObject.SetActive(false);
            dashdownbar1.gameObject.SetActive(false);
            dashdownbar2.gameObject.SetActive(false);
            dashdownbar3.gameObject.SetActive(false);
            dashdownbare1.gameObject.SetActive(false);
            dashdownbare2.gameObject.SetActive(false);
            dashdownbare3.gameObject.SetActive(true);


            dashup1.gameObject.SetActive(false);
            dashup2.gameObject.SetActive(false);
            dashup3.gameObject.SetActive(false);
            dashup4.gameObject.SetActive(true);
            dashdown1.gameObject.SetActive(true);
            dashdown2.gameObject.SetActive(false);
            dashdown3.gameObject.SetActive(false);
            dashdown4.gameObject.SetActive(false);
        }

        else if (kontroldash == -1)
        {
            dashbar0.gameObject.SetActive(false);
            dashbar1.gameObject.SetActive(false);
            dashbar2.gameObject.SetActive(false);
            dashbar3.gameObject.SetActive(false);
            dashbare1.gameObject.SetActive(true);
            dashbare2.gameObject.SetActive(false);
            dashbare3.gameObject.SetActive(false);
            dashdownbar0.gameObject.SetActive(false);
            dashdownbar1.gameObject.SetActive(true);
            dashdownbar2.gameObject.SetActive(false);
            dashdownbar3.gameObject.SetActive(false);
            dashdownbare1.gameObject.SetActive(false);
            dashdownbare2.gameObject.SetActive(false);
            dashdownbare3.gameObject.SetActive(false);


            dashup1.gameObject.SetActive(true);
            dashup2.gameObject.SetActive(false);
            dashup3.gameObject.SetActive(false);
            dashup4.gameObject.SetActive(false);
            dashdown1.gameObject.SetActive(false);
            dashdown2.gameObject.SetActive(true);
            dashdown3.gameObject.SetActive(false);
            dashdown4.gameObject.SetActive(false);
        }

        else if (kontroldash == -2)
        {
            dashbar0.gameObject.SetActive(false);
            dashbar1.gameObject.SetActive(false);
            dashbar2.gameObject.SetActive(false);
            dashbar3.gameObject.SetActive(false);
            dashbare1.gameObject.SetActive(false);
            dashbare2.gameObject.SetActive(true);
            dashbare3.gameObject.SetActive(false);
            dashdownbar0.gameObject.SetActive(false);
            dashdownbar1.gameObject.SetActive(false);
            dashdownbar2.gameObject.SetActive(true);
            dashdownbar3.gameObject.SetActive(false);
            dashdownbare1.gameObject.SetActive(false);
            dashdownbare2.gameObject.SetActive(false);
            dashdownbare3.gameObject.SetActive(false);


            dashup1.gameObject.SetActive(true);
            dashup2.gameObject.SetActive(false);
            dashup3.gameObject.SetActive(false);
            dashup4.gameObject.SetActive(false);
            dashdown1.gameObject.SetActive(false);
            dashdown2.gameObject.SetActive(false);
            dashdown3.gameObject.SetActive(true);
            dashdown4.gameObject.SetActive(false);
        }

        else if (kontroldash == -3)
        {
            dashbar0.gameObject.SetActive(false);
            dashbar1.gameObject.SetActive(false);
            dashbar2.gameObject.SetActive(false);
            dashbar3.gameObject.SetActive(false);
            dashbare1.gameObject.SetActive(false);
            dashbare2.gameObject.SetActive(false);
            dashbare3.gameObject.SetActive(true);
            dashdownbar0.gameObject.SetActive(false);
            dashdownbar1.gameObject.SetActive(false);
            dashdownbar2.gameObject.SetActive(false);
            dashdownbar3.gameObject.SetActive(true);
            dashdownbare1.gameObject.SetActive(false);
            dashdownbare2.gameObject.SetActive(false);
            dashdownbare3.gameObject.SetActive(false);


            dashup1.gameObject.SetActive(true);
            dashup2.gameObject.SetActive(false);
            dashup3.gameObject.SetActive(false);
            dashup4.gameObject.SetActive(false);
            dashdown1.gameObject.SetActive(false);
            dashdown2.gameObject.SetActive(false);
            dashdown3.gameObject.SetActive(false);
            dashdown4.gameObject.SetActive(true);
        }
    }
}
