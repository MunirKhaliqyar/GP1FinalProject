using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapController : MonoBehaviour
{
    private static int trapAmount = 0;
    private Animator animator;
    [SerializeField] private GameObject trap;

    private int maxTrapAmount = 4;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        Vector2 player1Pos = GameManager.player1.transform.position;
        Vector2 player2Pos = GameManager.player2.transform.position;
        
        float maxHeight = Random.Range(-4.5f, 4.5f);
        float maxWeith = Random.Range(-7.5f, 10f);
        Vector2 trapPosition = new Vector2(maxWeith, maxHeight);

        // Get the distance between object1 and object2
        float player1Distance = Vector2.Distance(player1Pos, trapPosition);
        float player2Distance = Vector2.Distance(player2Pos, trapPosition);

        if (trapAmount < maxTrapAmount)
        
            if (player1Distance > 3 && player2Distance > 3)
            {
                trapAmount++;
                GameObject newTrap = Instantiate(trap, trapPosition, Quaternion.Euler(0,0,180f));
                newTrap.SetActive(true);
            }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player1") || collision.gameObject.CompareTag("Player2"))
        {
            animator.SetBool("Explosion", true);
            trapAmount--;
            Destroy(this.gameObject, 1f);
        }
    }
}
