using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankLife : MonoBehaviour
{
    [SerializeField] AudioSource healthPickupSound;

    HealthController healthController;
    //Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        healthController = GetComponent<HealthController>();
        //animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullets")
        {
            Debug.Log("Taking damage");
            //animator.SetBool("Explosion", true);
            other.gameObject.SetActive(false);
            healthController.TakeDamage(1);
        }

        if (other.tag == "Barrel" || other.tag == "Mine" )
        {
            healthController.TakeDamage(1);
        }
        
        if (other.tag == "HealthPack")
        {
            healthController.Heal(1);
            healthPickupSound.Play();
        }
    }
}
