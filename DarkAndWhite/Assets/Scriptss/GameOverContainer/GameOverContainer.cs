using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverContainer : MonoBehaviour
{
    public ObstacleSpawner obstacleSpawner;
    public void restart()
    {
        obstacleSpawner.spawnTiming = obstacleSpawner.startSpawnTiming;
        Time.timeScale = 1;
        SceneManager.LoadScene("GameScene");
    }

    public void mainmenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
}
