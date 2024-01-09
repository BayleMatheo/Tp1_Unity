using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class SpawnAsteroid : MonoBehaviour
{
    public float spawnRate = 2.0f;
    public int spawnAmount = 1;
    public float traj = 15.0f;
    public float spawnDistance = 15.0f;
    public Asteroid asteroidPrefab;
    private void Start()
    {
       InvokeRepeating(nameof(Spawn), this.spawnRate, this.spawnRate ); 
    }

    private void Spawn()
    {
        for (int i = 0; i < this.spawnRate; i++)
        {
            Vector3 spawnDirection = UnityEngine.Random.insideUnitCircle.normalized * this.spawnDistance;
            Vector3 spawnPoint = this.transform.position + spawnDirection;
            float variation = UnityEngine.Random.Range(-this.traj, this.traj);
            Quaternion rotation = Quaternion.AngleAxis(variation,Vector3.forward);
            Asteroid asteroid = Instantiate(this.asteroidPrefab, spawnPoint, rotation);
            asteroid.size = UnityEngine.Random.Range(asteroid.minSize, asteroid.maxSize);
            Vector2 trajectory = rotation * -spawnDirection;
            asteroid.SetTraj(trajectory);
        }
    }
}
