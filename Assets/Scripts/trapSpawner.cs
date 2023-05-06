using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class trapSpawner : MonoBehaviour
{
    public static int barrelAmount = 0;
    public static int mineAmount = 0;

    [SerializeField] GameObject Barrel;
    [SerializeField] GameObject Mine;

    private int maxNumberBarrel;
    private int maxNumberMine;


    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetString("mapChoice") == "easyScene")
        {
            maxNumberBarrel = 2;
            maxNumberMine = 2;
        }
        else if(PlayerPrefs.GetString("mapChoice") == "hardScene")
        {
            maxNumberBarrel = 5;
            maxNumberMine = 5;
        }

        while(barrelAmount < maxNumberBarrel)
        {
            SpawnBarrel();
        }
        while(mineAmount < maxNumberMine)
        {
            SpawnMine();
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Mines: " + mineAmount);
        Debug.Log("Barrels: " + barrelAmount);

        if (barrelAmount < maxNumberBarrel)
        {
            SpawnBarrel();
        }

        if (mineAmount < maxNumberMine)
        {

            SpawnMine();
        }
    }

    private void SpawnBarrel()
    {
        Vector2 player1Pos = GameManager.player1.transform.position;
        Vector2 player2Pos = GameManager.player2.transform.position;

        float maxHeight = Random.Range(-4f, 4f);
        float maxWeith = Random.Range(-8.5f, 8f);
        Vector2 trapPosition = new Vector2(maxWeith, maxHeight);

        // Get the distance between object1 and object2
        float player1Distance = Vector2.Distance(player1Pos, trapPosition);
        float player2Distance = Vector2.Distance(player2Pos, trapPosition);

        if (player1Distance > 3 && player2Distance > 3)
        {
            barrelAmount++;
            GameObject newTrap = Instantiate(Barrel, trapPosition, Quaternion.Euler(0, 0, 180f));
            newTrap.SetActive(true);
        }
    }

    private void SpawnMine()
    {
        Vector2 player1Pos = GameManager.player1.transform.position;
        Vector2 player2Pos = GameManager.player2.transform.position;

        float maxHeight = Random.Range(-4.5f, 4.5f);
        float maxWeith = Random.Range(-7.5f, 10f);
        Vector2 trapPosition = new Vector2(maxWeith, maxHeight);

        // Get the distance between object1 and object2
        float player1Distance = Vector2.Distance(player1Pos, trapPosition);
        float player2Distance = Vector2.Distance(player2Pos, trapPosition);

        if (player1Distance > 3 && player2Distance > 3)
        {
            mineAmount++;
            GameObject newTrap = Instantiate(Mine, trapPosition, Quaternion.Euler(0, 0, 180f));
            newTrap.SetActive(true);
        }
    }
}
