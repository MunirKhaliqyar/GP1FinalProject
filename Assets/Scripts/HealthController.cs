using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    [SerializeField] private int initialHealth = 3;

    private int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        ResetHealth();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void ResetHealth()
    {
        currentHealth = initialHealth;
    }

    public void Heal(int healAmount)
    {
        currentHealth += healAmount;

        if (currentHealth > initialHealth)
        {
            ResetHealth();
        }
    }
}
