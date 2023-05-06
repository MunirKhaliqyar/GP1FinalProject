using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankLife : MonoBehaviour
{
    HealthController healthController;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        healthController = GetComponent<HealthController>();
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Bullets")
        {
            Debug.Log("Taking damage");
            animator.SetBool("Explosion", true);
            Destroy(this.gameObject, 1f);
            healthController.TakeDamage(2);
        }

        if(other.tag == "Barrel" ||  other.tag == "Mine")
        {
            healthController.TakeDamage(1);
        }
    }
}
