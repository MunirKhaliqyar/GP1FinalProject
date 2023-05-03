using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIController : MonoBehaviour
{
    public Slider slider;

    [SerializeField]  GameObject endGameUI;
    [SerializeField]  GameObject healthUI;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }

    public void Restart()
    {
        healthUI.SetActive(false);
        endGameUI.SetActive(true);
    }

    public void ReloadPlayScene()
    {
        healthUI.SetActive(true);
    }
}
