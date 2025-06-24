using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject nivelPrefab;
    public float tiempoSpawns = 2f; // Tiempo entre cada spawn
    public float maxY = 10f; // Altura máxima para el spawn
    public float minY = -10f; // Altura mínima para el spawn

    private float timer = 0f;
    //update mode
    void Update()
    {
    timer += Time.deltaTime;

    if (timer >= tiempoSpawns)
    {
        SpawnNivel();
        timer = 0f;
    }
    }

    void SpawnNivel()
    {
        // Genera una posición aleatoria dentro de los límites especificados
        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPosition = new Vector3(transform.position.x, randomY, transform.position.z);

        // Instancia el prefab en la posición generada
        Instantiate(nivelPrefab, spawnPosition, Quaternion.identity);
    }
}


