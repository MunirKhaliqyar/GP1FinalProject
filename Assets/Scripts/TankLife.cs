using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankLife : MonoBehaviour
{
    HealthController healthController;
    // Start is called before the first frame update
    void Start()
    {
        healthController = GetComponent<HealthController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Bullets")
        {
            Debug.Log("Taking damage");
            healthController.TakeDamage(1);
        }
    }
}
