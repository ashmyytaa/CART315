using UnityEngine;

public class ParticleSpawner : MonoBehaviour
{
    public GameObject particlePrefab;
    public float spawnRate = 0.04f; //rate at how much particles are getting spawned

    private void Start() //continously spawns particles
    {
        InvokeRepeating(nameof(SpawnParticle), 0f, spawnRate);
    }

    private void SpawnParticle()
    {
        float y = Random.Range(-4f, 4f); //assinging random vertical position

        Vector3 position = new Vector3(10f, y, 0f);

        Instantiate(particlePrefab, position, Quaternion.identity);
    }
}