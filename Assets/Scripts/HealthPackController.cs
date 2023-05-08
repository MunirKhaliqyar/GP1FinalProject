using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPackController : MonoBehaviour
{
    private AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player1") || collision.gameObject.CompareTag("Player2"))
        {
            audio.Play();
            Debug.Log("collison with hp");
            healPackSpawner.healthPacksAmount--;
            Destroy(this.gameObject, 0.5f);
        }
    }
}
