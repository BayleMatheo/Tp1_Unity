using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawn_Asteroides : MonoBehaviour
{
    public GameObject squarePrefab;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 randomSpawnPos = new Vector3(Random.Range(-10, -11), Random.Range(-10,-11));
            Instantiate(squarePrefab, randomSpawnPos, Quaternion.identity);
        }
    }
}
