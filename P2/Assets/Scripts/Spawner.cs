using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Pipes prefab;
    public float spawnRate = 1f; 
    public float minHeight = -1f; //spawn range
    public float maxHeight = 2f; //spawn range
    public float verticalGap = 3f;  //height pbetwwen each spawns

    private void OnEnable() //calling spawn function
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable() //stops spawn function
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn() //creating new spawners
    {
        Pipes pipes = Instantiate(prefab, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
        pipes.gap = verticalGap;
    }

}
