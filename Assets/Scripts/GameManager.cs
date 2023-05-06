using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text rightUser;
    [SerializeField] Text leftUser;

    // Start is called before the first frame update
    void Start()
    {
        rightUser.text = PlayerPrefs.GetString("rightUserName");
        leftUser.text = PlayerPrefs.GetString("leftUserName");
    }
}
