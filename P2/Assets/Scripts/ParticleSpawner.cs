using UnityEngine;

public class ParticleSpawner : MonoBehaviour
{
    public GameObject particlePrefab;
    public float spawnRate = 0.04f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnParticle), 0f, spawnRate);
    }

    private void SpawnParticle()
    {
        float y = Random.Range(-4f, 4f);

        Vector3 position = new Vector3(10f, y, 0f);

        Instantiate(particlePrefab, position, Quaternion.identity);
    }
}