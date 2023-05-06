using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsController : MonoBehaviour
{
    private RawImage tank;
    private RawImage map;

    // Start is called before the first frame update
    void Start()
    {
        tank = GetComponentInParent<RawImage>();
        map = GetComponentInParent<RawImage>();
    }

    public void saveLeftTankColor()
    {
        PlayerPrefs.SetString("leftTankColor", tank.mainTexture.name);
        Debug.Log(tank.texture.name);

    }

    public void saveRightTankColor()
    {
        Debug.Log(tank.mainTexture.name);
        PlayerPrefs.SetString("rightTankColor", tank.mainTexture.name);
    }

    public void saveMapChoice()
    {
        PlayerPrefs.SetString("mapChoice", map.mainTexture.name);
        Debug.Log(map.mainTexture.name);
    }
}
