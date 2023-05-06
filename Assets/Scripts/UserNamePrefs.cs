using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserNamePrefs : MonoBehaviour
{
    [SerializeField] InputField rightUserName;
    [SerializeField] InputField leftUserName;
    // Start is called before the first frame update
  
    public void savePlayerPrefs()
    {
        PlayerPrefs.SetString("rightUserName", rightUserName.text);
        PlayerPrefs.SetString("leftUserName", leftUserName.text);
    }
}
