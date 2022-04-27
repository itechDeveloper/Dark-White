using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnGame : MonoBehaviour
{
    public PauseMenu pauseMenu;
    public void unpause()
    {
        Time.timeScale = 1f;
        pauseMenu.pause = false;
    }

}
