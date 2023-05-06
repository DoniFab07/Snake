using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class SpawnObject : MonoBehaviour
{
    public GameObject[] musor;
    public Transform Snake;
    public Transform[] SpawnPoint;
    
    void Start()
    {
        InvokeRepeating("SpawnMusor",2, Random.Range(2,5));
    }

    private void Update()
    {
        transform.position = Snake.position;
    }

    void SpawnMusor()
    {
        Instantiate(musor[Random.Range(0,2)],SpawnPoint[Random.Range(0,4)].position,Quaternion.identity);
    }
}