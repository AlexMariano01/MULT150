using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject startButton;
    public GameObject startPanel;
    public GoalScript blue,green,red,orange;
    private bool isGameOver = true;

    void Start()
    {
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        startButton.SetActive(true);
        startPanel.SetActive(true);
    }
    public void StartGame()
    {
        startButton.SetActive(false);
        startPanel.SetActive(false);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {
        //If all four goals are solved then the game is over
        isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved;
    }
    void OnGUI()
    {
        if(isGameOver)
        {
            Rect rect = new Rect (Screen.width / 2 - 100, Screen.height / 2 - 50,200,75);
            GUI.Box(rect,"Game Over");
            Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height / 2 - 25,60,50);
            GUI.Label(rect2,"Good Job!");
            if(GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 30, 100, 40), "Play Again"))
            {
                RestartGame();
            }
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        Time.timeScale = 1;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
