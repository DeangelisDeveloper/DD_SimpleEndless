using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [Header("General")]
    [SerializeField] GameObject obstaclePrefab = null;
    [SerializeField] float maxSpawnTime = 0f;
    [SerializeField] float spawnHeightOffset = 0f;
    [SerializeField] float obstacleDestroyTime = 0f;
    float spawnTime;

    void Start()
    {
        spawnTime = 0f;
    }

    void Update()
    {
        if (Manager.instance.inGame == true)
            Spawn();
    }

    void Spawn()
    {
        if (spawnTime > maxSpawnTime)
        {
            GameObject obstacleInstance = Instantiate(obstaclePrefab);
            obstacleInstance.transform.position = transform.position + new Vector3(0, Random.Range(-spawnHeightOffset, spawnHeightOffset), 0);
            Destroy(obstacleInstance, obstacleDestroyTime);
            spawnTime = 0f;
        }

        spawnTime += Time.deltaTime;
    }
}
