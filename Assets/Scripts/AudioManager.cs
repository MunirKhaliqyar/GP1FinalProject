using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField] Slider audioSlider;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("audioVolume"))
        {
            PlayerPrefs.SetFloat("audioVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }

    public void ChangeVolume()
    {
        AudioListener.volume = audioSlider.value;
        Save();
    }

    private void Load()
    {
        AudioListener.volume = PlayerPrefs.GetFloat("audioVolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("audioVolume", audioSlider.value);
    }
}
