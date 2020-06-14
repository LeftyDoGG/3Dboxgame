using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBox : MonoBehaviour
{
    [SerializeField]
    private float minX = 0.0f;
    [SerializeField]
    private float maxX = 0.0f;
    [SerializeField]
    private int minBoxToSpawn = 1;
    [SerializeField]
    private int maxBoxToSpawn = 6;
    [SerializeField]
    private GameObject[] Box;
    [SerializeField]
    private float timeBetweenSpwan = 0.0f;
    private bool canSpawn = false;
    private int amoutOfBoxTospawn = 0;
    private int BoxToSpawn = 0;
    private int BoxToSpawnCap = 8;

    void Start()
    {
        canSpawn = true;
    }
    void Update()
    {
        if (canSpawn == true) 
        {
            StartCoroutine("GenerateBox");
        }
    }

    private IEnumerator GenerateBox() 
    {
        canSpawn = false;
        timeBetweenSpwan = Random.Range(0.5f, 2.0f);
        amoutOfBoxTospawn = Random.Range(minBoxToSpawn, maxBoxToSpawn);
        for (int i = 0; i < amoutOfBoxTospawn; i++) 
        {
            Vector3 spawnPos = new Vector3(Random.Range(minX, maxX), 8.0f, 0.0f);
            Instantiate(Box[BoxToSpawn], spawnPos, Quaternion.identity);
        }
        
        yield return new WaitForSeconds(timeBetweenSpwan);
        canSpawn = true;
    }
}
