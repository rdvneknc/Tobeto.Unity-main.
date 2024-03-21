using UnityEngine;

public class CollectibleController : MonoBehaviour
{
    public GameObject[] collectiblesToSpawn; // Oluşturulacak objelerin dizisi
    public Vector3 spawnAreaCenter; // Objelerin oluşturulacağı alanın merkezi
    public Vector2 spawnAreaSize; // Objelerin oluşturulacağı alanın boyutları
    public float spawnInterval = 5f; // Objelerin oluşturulma aralığı (saniye)

    private void Start()
    {
        // Belirli aralıklarla SpawnObjects metodunu çağırarak objelerin oluşturulmasını sağlar
        InvokeRepeating("SpawnCollectibles", 0f, spawnInterval);
    }

    private void SpawnCollectibles()
    {
        // Oluşturulacak objenin rasgele seçilmesi
        GameObject objectToSpawn = collectiblesToSpawn[Random.Range(0, collectiblesToSpawn.Length)];

        // Oluşturulacak konumun belirlenmesi
        Vector3 spawnPosition = GetRandomSpawnPosition();

        // Objenin oluşturulması
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }

    // Objelerin oluşturulacağı rasgele bir konum alır
    private Vector3 GetRandomSpawnPosition()
    {
        float randomX = Random.Range(-spawnAreaSize.x / 2f, spawnAreaSize.x / 2f);
        float randomZ = Random.Range(-spawnAreaSize.y / 2f, spawnAreaSize.y / 2f);

        Vector3 spawnPosition = spawnAreaCenter + new Vector3(randomX, 0.45f, randomZ);
        return spawnPosition;
    }

    private void OnDrawGizmosSelected()
    {
        // Editörde spawn alanını görselleştirir
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(spawnAreaCenter, new Vector3(spawnAreaSize.x, 0.1f, spawnAreaSize.y));
    }
}