using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineController : MonoBehaviour
{
    private Animator animator;
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        audio = gameObject.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player1") || collision.gameObject.CompareTag("Player2"))
        {
            audio.Play();
            animator.SetBool("Explosion", true);
            trapSpawner.mineAmount--;
            Destroy(this.gameObject, 2f);
        }
    }
}
