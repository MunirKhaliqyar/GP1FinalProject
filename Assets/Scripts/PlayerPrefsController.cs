using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsController : MonoBehaviour
{
    private RawImage map;

    // Start is called before the first frame update
    void Start()
    {
        map = GetComponentInParent<RawImage>();
    }

    public void saveMapChoice()
    {
        PlayerPrefs.SetString("mapChoice", map.mainTexture.name);
        Debug.Log(map.mainTexture.name);
    }
}
