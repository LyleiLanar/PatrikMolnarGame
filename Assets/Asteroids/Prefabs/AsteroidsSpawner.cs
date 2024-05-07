using System.Collections.Generic;
using UnityEngine;

public class AsteroidsSpawner : MonoBehaviour
{

    [SerializeField] Asteroid[] asteroidPrefabs;
    [SerializeField] int count;
    [SerializeField] int spawnDistance;

    List<Asteroid> asteroids = new();

    private void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        for (int i = 0; i < count; i++)
        {
            int which = Random.Range(0, asteroidPrefabs.Length);
            Asteroid newAsteroid = Instantiate(asteroidPrefabs[which]);
            asteroids.Add(newAsteroid);

            Vector2 newPosition = Random.insideUnitCircle.normalized * spawnDistance;
            newAsteroid.transform.position = newPosition;
        }
    }
    public void RemoveAsteroid(Asteroid asteroid)
    {
        asteroids.Remove(asteroid);
        if (IsEveryAsteroidsDestroyed())
            Debug.Log("stage cleared");
    }

    public bool IsEveryAsteroidsDestroyed()
    {
        return asteroids.Count == 0;
    }
}
