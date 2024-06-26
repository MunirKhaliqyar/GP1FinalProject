using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLifeTime : MonoBehaviour
{
    [SerializeField] float lifeTime = 3f;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Wall"))
        {
            Destroy(this.gameObject);
        }

        if(collision.CompareTag("Player") || collision.CompareTag("Player2"))
        {
            animator.SetBool("Explosion", true);
            Destroy(this.gameObject, 1f);

        }
    }
}
