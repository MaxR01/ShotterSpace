using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemycontroller : MonoBehaviour
{
    public float testNumber;
    public float maxnumber = 1;
    public Rigidbody2D MyEnemy;
    public GameObject Spawning;
    public GameObject Spawning1;
    public GameObject Spawning2;
    public Transform SpawnPos;
    public float YvalueMax;
    public float YvalueMin;

    public float maxTime;
    public float minTime;
    private float timer;
    private float Fasttimer2;
    private float fasttimer;

    void Start()
    {
        minTime = 2;
        maxTime = 3;
    }

    void Update()
    {
        if (GameObject.FindWithTag("Player").GetComponent<PlayerMovement>().Score >= 50)
        {
            minTime = 1f;
            maxTime = 2f;

            Fasttimer2 -= Time.deltaTime;
            if (Fasttimer2 <= 0)
            {
                SpawnRandom();
                Fasttimer2= Random.Range(minTime, maxTime);
            }
        }
        else if (GameObject.FindWithTag("Player").GetComponent<PlayerMovement>().Score >= 200)
        {
            minTime = 0f;
            maxTime = 1f;
            fasttimer -= Time.deltaTime;
            if (fasttimer <= 0)
            {
                SpawnRandom();
                fasttimer = Random.Range(minTime, maxTime);
            }
        }
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            SpawnRandom();
            timer = Random.Range(minTime, maxTime);
        }

    }
    void SpawnRandom()
    {
        int spawnEnemy = Random.Range(0, 3);
        if (spawnEnemy == 0)
        {
            Instantiate(Spawning, new Vector2(10, Random.Range(YvalueMax, YvalueMin)), Quaternion.identity);
        }
        else if (spawnEnemy == 1)
        {
            Instantiate(Spawning1, new Vector2(10, Random.Range(YvalueMax, YvalueMin)), Quaternion.identity);

        }
        else if (spawnEnemy == 2)
        {
            Instantiate(Spawning2, new Vector2(10, Random.Range(YvalueMax, YvalueMin)), Quaternion.identity);
        }
    }

}
