using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public bool pause;
    public void Pausee()
    {
        Time.timeScale = 0f;
        pause = true;
    }

}
