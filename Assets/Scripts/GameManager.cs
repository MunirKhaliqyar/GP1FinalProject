using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameObject player1;
    public static GameObject player2;
    [SerializeField] GameObject p1;
    [SerializeField] GameObject p2;

    // Start is called before the first frame update
    void Start()
    {
        player1 = p1;
        player2 = p2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
