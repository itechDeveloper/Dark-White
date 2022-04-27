using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceOfSeperatedObstacle : MonoBehaviour
{
    public string number;
    public float verticalSpeed;
    public float horizontalSpeed;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > -30f)
        {
            if (number == "first")
            {
                transform.Translate(new Vector2(horizontalSpeed * Time.deltaTime, verticalSpeed * Time.deltaTime));
            }
            else if (number == "second")
            {

                transform.Translate(new Vector2(horizontalSpeed * Time.deltaTime, 0));
            }
            else if (number == "third")
            {
                transform.Translate(new Vector2(horizontalSpeed * Time.deltaTime, -verticalSpeed * Time.deltaTime));
            }
        }     
    }
}
