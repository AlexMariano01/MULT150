using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFollows : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, player.transform.position, speed);
    }
}
