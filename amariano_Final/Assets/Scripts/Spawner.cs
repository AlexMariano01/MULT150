using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject doughnutPrefab;
    public GameObject powerupPrefab;
    public GameObject obstaclePrefab;
    public float spawnCycle = .5f;

    private GameManager manager;
    private float elapsedTime;
    private bool spawnPowerup = true;

    void Start()
    {
        manager = GetComponent<GameManager>();
    }

void Update()
{
    elapsedTime += Time.deltaTime;
    if (elapsedTime > spawnCycle)
    {
        elapsedTime = 0;
        GameObject temp;

        int spawnChoice = Random.Range(0, 3); 

        if (spawnChoice == 0 && spawnPowerup)
        {
            temp = Instantiate(powerupPrefab) as GameObject;
        }
        else if (spawnChoice == 1)
        {
            temp = Instantiate(obstaclePrefab) as GameObject;
        }
        else
        {
            temp = Instantiate(doughnutPrefab) as GameObject;
        }
        Vector3 position = temp.transform.position;
        position.x = Random.Range(-3f, 3f);
        temp.transform.position = position;

        Collidable col = temp.GetComponent<Collidable>();
        col.manager = manager;

        elapsedTime = 0;
        spawnPowerup = !spawnPowerup;
        }
    }
}

