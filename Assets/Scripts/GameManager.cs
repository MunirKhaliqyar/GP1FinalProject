using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameObject player1;
    public static GameObject player2;
    [SerializeField] Text rightUser;
    [SerializeField] Text leftUser;

    // Start is called before the first frame update
    void Start()
    {
        rightUser.text = PlayerPrefs.GetString("rightUserName");
        leftUser.text = PlayerPrefs.GetString("leftUserName");
    }
}
