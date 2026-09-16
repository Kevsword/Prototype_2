using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float _spawnPosX = 20.0f;
    private float _spawnPosZ = 20.0f;

    private float _startDelay = 2.0f;
    private float _spawnInterval = 1.5f;

    void Start()
    {
        // Start spawning animals with delay
        InvokeRepeating(nameof(SpawnRandomAnimal), _startDelay, _spawnInterval);
    }

    // Set random spawn position and animal, then instantiate
    private void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new(Random.Range(-_spawnPosX, _spawnPosX), 0, _spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
