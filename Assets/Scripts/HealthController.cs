using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    [SerializeField] public int initialHealth = 3;

    UIController uIcontroller;

    public int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        uIcontroller = gameObject.GetComponent<UIController>();
       // uIController.SetMaxHealth(initialHealth);
        ResetHealth();
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
            uIcontroller.Restart();
            // do something
        }
        if (GameObject.Find("Player2"))
        {
            Debug.Log("player2 is alive");
        }
        else
        {
            Debug.Log("player2 is dead");
            uIcontroller.Restart();
            // do something
        }
    }

    void FixedUpdate()
    {
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
       // uIController.SetHealth(currentHealth);
        Debug.Log(currentHealth);

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            Debug.Log("player is dead");
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
}
