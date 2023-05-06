using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sceneManager : MonoBehaviour
{
    private Button startButton;
    private bool continueGame = false;

    private void Start()
    {
        startButton = GetComponent<Button>();
        startButton.enabled = false;
    }

    private void Update()
    {
        string rightUserName = PlayerPrefs.GetString("rightUserName");
        string leftUserName = PlayerPrefs.GetString("leftUserName");
        string rightTankColor = PlayerPrefs.GetString("rightTankColor");
        string leftTankColor = PlayerPrefs.GetString("leftTankColor");
        string mapChoice = PlayerPrefs.GetString("mapChoice");

        if (rightUserName == "" || leftUserName == "" || rightTankColor == leftTankColor || mapChoice == "")
        {
            continueGame = false;
            startButton.enabled = false;
        }
        else
        {
            continueGame = true;
            startButton.enabled = true;

        }
    }

    public void StartGame()
    {
        if (continueGame == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
