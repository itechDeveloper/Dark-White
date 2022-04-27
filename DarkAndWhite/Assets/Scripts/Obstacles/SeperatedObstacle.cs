using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeperatedObstacle : MonoBehaviour
{
    public float waitTime;
    public GameObject firstseperatedObject;
    public GameObject secondseperatedObject;
    public GameObject thirdseperatedObject;
    public float speed;
   
    void Update()
    {
        IEnumerator enumerator = SeperateObstacle();
        StartCoroutine(enumerator);
        transform.Translate(new Vector2(speed * Time.deltaTime, 0));
    }

    private IEnumerator SeperateObstacle()
    {
        yield return new WaitForSeconds(waitTime);
        if (transform.position.x > -30f) {
            if (firstseperatedObject != null)
            {
                Instantiate(firstseperatedObject, transform.position, Quaternion.identity);
            }
            if(secondseperatedObject != null)
            {
                Instantiate(secondseperatedObject, transform.position, Quaternion.identity);
            }
            if (thirdseperatedObject != null)
            {

                Instantiate(thirdseperatedObject, transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }
}
