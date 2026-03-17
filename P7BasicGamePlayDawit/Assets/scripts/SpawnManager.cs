using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float xSpawnRange = 20f;
    private float zSpawnTop = 1f;
    private float zSideRange = 10f;

    private float startDelay = 2f;
    private float topSpawnInterval = 1.5f;
    private float sideSpawnInterval = 2.0f;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalTop", startDelay, topSpawnInterval);
        InvokeRepeating("SpawnRandomAnimalLeft", startDelay, sideSpawnInterval);
        InvokeRepeating("SpawnRandomAnimalRight", startDelay, sideSpawnInterval);
    }

    void SpawnRandomAnimalTop()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-xSpawnRange, xSpawnRange), 0, zSpawnTop);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnRandomAnimalLeft()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-xSpawnRange, 0, Random.Range(0, zSideRange));

        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, 90, 0));
    }

    void SpawnRandomAnimalRight()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(xSpawnRange, 0, Random.Range(0, zSideRange));

        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, -90, 0));
    }
}