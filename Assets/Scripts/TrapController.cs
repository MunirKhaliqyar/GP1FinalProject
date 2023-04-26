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
        float maxHeight = Random.Range(-4.5f, 4.5f);
        float maxWeith = Random.Range(-7.5f, 10f);
        Vector2 position = new Vector2(maxWeith, maxHeight);
        if(trapAmount < maxTrapAmount)
        {
            trapAmount++;
            GameObject newTrap = Instantiate(trap, position, Quaternion.Euler(0,0,180f));
            newTrap.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            animator.SetBool("Explosion", true);
            trapAmount--;
            Destroy(this.gameObject, 1f);
        }
    }
}
