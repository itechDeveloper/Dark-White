using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMainPendulum : MonoBehaviour
{
    public GameObject child;

    void Update()
    {
        if (child == null)
        {
            Destroy(gameObject);
        }
    }
}
