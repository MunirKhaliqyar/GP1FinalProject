using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class healPackSpawner : MonoBehaviour
{
    public static int healthPacksAmount = 0;

    [SerializeField] GameObject healthPack;
    [SerializeField] GameObject player;
    [SerializeField] GameObject player2;

    private int maxNumberHealthPacks;
    private int nextSpawnTime = 5;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetString("mapChoice") == "easyScene")
        {
            maxNumberHealthPacks = 2;
        }
        else if(PlayerPrefs.GetString("mapChoice") == "hardScene")
        {
            maxNumberHealthPacks = 1;
        }

        while(healthPacksAmount < maxNumberHealthPacks)
        {
            SpawnPacks();
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Health Packs: " + healthPacksAmount);

        if(healthPacksAmount < maxNumberHealthPacks )
        {
            SpawnPacks();
        }
    }

    private void SpawnPacks()
    {
        Vector2 player1Pos = player.transform.position;
        Vector2 player2Pos = player2.transform.position;

        float maxHeight = Random.Range(-4f, 4f);
        float maxWeith = Random.Range(-8.5f, 8f);
        Vector2 healthPackPosition = new Vector2(maxWeith, maxHeight);

        // Get the distance between object1 and object2
        float player1Distance = Vector2.Distance(player1Pos, healthPackPosition);
        float player2Distance = Vector2.Distance(player2Pos, healthPackPosition);

        if (player1Distance > 3 && player2Distance > 3 && Time.time > nextSpawnTime)
        {
            healthPacksAmount++;
            GameObject newHealthPacks = Instantiate(healthPack, healthPackPosition, Quaternion.Euler(0, 0, 180f));
            newHealthPacks.SetActive(true);
        }
    }
}
