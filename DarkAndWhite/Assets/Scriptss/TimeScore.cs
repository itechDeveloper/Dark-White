using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScore : MonoBehaviour
{
    public int secondtext;
    public float seconds;
    public Health health;

    private void Start()
    {
        seconds = 0;
    }
    private void Update()
    {
        if (health.health > 0)
        {
            secondtext = (int)seconds;
            seconds += Time.deltaTime;
        }
    }
}
