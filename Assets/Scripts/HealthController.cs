using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    [SerializeField] public int initialHealth = 10;
    [SerializeField] Slider slider;

    [SerializeField] GameObject endGameUI;
    [SerializeField] GameObject healthUI;

    [SerializeField] TextMeshProUGUI winnerText;

    Animator animator;


    public int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
       // uIController.SetMaxHealth(initialHealth);
        ResetHealth();
        animator = GetComponent<Animator>();
        SetMaxHealth(initialHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Player")){
            Debug.Log("player1 is alive");
        }
        else
        {
            Debug.Log("player1 is dead");
            // show restart ui
            winnerText.text = "Player 2 won!";
            Restart();


        }
        if (GameObject.Find("Player2"))
        {
            Debug.Log("player2 is alive");
        }
        else
        {
            Debug.Log("player2 is dead");
            // show restart ui
            winnerText.text = "Player 1 won!";
            Restart();
        }
    }

    void FixedUpdate()
    {
        SetHealth(currentHealth);

    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        Debug.Log(currentHealth);

        if (currentHealth <= 0)
        {
            animator.SetBool("death", true);
            Destroy(gameObject);
            Debug.Log("player is dead");
            Time.timeScale = 0;
        }
    }

    private void ResetHealth()
    {
        currentHealth = initialHealth;
    }

    public void Heal(int healAmount)
    {
        currentHealth += healAmount;
       // uIController.SetHealth(currentHealth + healAmount);
        Debug.Log("healing player");

        if (currentHealth > initialHealth)
        {
            ResetHealth();
        }
    }

    public void Restart()
    {
        healthUI.SetActive(false);
        endGameUI.SetActive(true);
    }

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }
}
