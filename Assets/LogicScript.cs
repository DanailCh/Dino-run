using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour//Score,gameover,startover
{
    public int score;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject obstacleSpawner;
    public GameObject floorSpawner;
    public GameObject cloudSpawner1;
    public GameObject cloudSpawner2;
    public GameObject cloudSpawner3;
    private FloorMoveSpeed floorMoveSpeed;
    private MoveSpeedScript obstacleMoveSpeed;
   
    [UnityEngine.ContextMenu("Increase Score")]
    public void IncreaseScore(int num)
    {
        score += num;
        scoreText.text = score.ToString();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        StopCloudObjects();
        StopObstacleObjects();
        StopFloorObjects();
    }
    private void StopFloorObjects()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("BigFloor");
        for (int i = 0; i < objects.Length; i++)
        {
            floorMoveSpeed = objects[i].GetComponent<FloorMoveSpeed>();
            floorMoveSpeed.Stop();
        }
        floorSpawner.SetActive(false);
    }
    private void StopObstacleObjects()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Obstacle");
        for (int i = 0; i < objects.Length; i++)
        {
            obstacleMoveSpeed = objects[i].GetComponent<MoveSpeedScript>();
            obstacleMoveSpeed.Stop();
        }
        obstacleSpawner.SetActive(false);
    }
    private void StopCloudObjects()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Cloud");
        for (int i = 0; i < objects.Length; i++)
        {
            obstacleMoveSpeed = objects[i].GetComponent<MoveSpeedScript>();
            obstacleMoveSpeed.Stop();
        }
        cloudSpawner1.SetActive(false);
        cloudSpawner2.SetActive(false);
        cloudSpawner3.SetActive(false);
    }


}
