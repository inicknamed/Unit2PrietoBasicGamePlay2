using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public GameObject[] animalPrefabsAggressive;
    private float xSpawnRange = 10.0f;
    private float zSpawnPos = 35.0f;
    private float startDelay = 3;
    private float spawnInterval = 1.0f;
    private float spawnInterval2 = 2.0f;
    private float startdelay2 = 5.0f;
    private float sideSpawnMinz = 3.0f;
    private float sideSpawnMaxz = 15.0f;
    private float sidespawnx = 20.0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalLeft", startdelay2, spawnInterval2);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnpos = new Vector3(Random.Range(-xSpawnRange, xSpawnRange), 0 ,zSpawnPos);
        Instantiate(animalPrefabs[animalIndex], spawnpos, Quaternion.Euler(0, 180, 0));
    }
    void SpawnRandomAnimalLeft()
    {
        int animalIndex = Random.Range(0, animalPrefabsAggressive.Length);
        Vector3 spawnpos = new Vector3(-sidespawnx, 0, Random.Range(sideSpawnMinz, sideSpawnMaxz));
        Instantiate(animalPrefabsAggressive[animalIndex], spawnpos, Quaternion.Euler(0, 90, 0));
    }
    void SpawnRandomAnimalRight()
    {
        int animalIndex = Random.Range(0, animalPrefabsAggressive.Length);
        Vector3 spawnpos = new Vector3(sidespawnx, 0, Random.Range(sideSpawnMinz, sideSpawnMaxz));
        Instantiate(animalPrefabsAggressive[animalIndex], spawnpos, Quaternion.Euler(0, -90, 0));
    }
}