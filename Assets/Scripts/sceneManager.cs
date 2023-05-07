using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sceneManager : MonoBehaviour
{
    private bool continueGame = false;
    string mapChoice;
    private void Update()
    {
        string rightUserName = PlayerPrefs.GetString("rightUserName");
        string leftUserName = PlayerPrefs.GetString("leftUserName");
        mapChoice = PlayerPrefs.GetString("mapChoice");

        if (rightUserName == "" || leftUserName == "" || mapChoice == "")
        {
            continueGame = false;
        }
        else
        {
            continueGame = true;

        }
    }

    public void StartGame()
    {
        if (continueGame == true && mapChoice == "easyScene")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if(continueGame == true && mapChoice == "hardScene")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }
}
