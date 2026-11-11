using UnityEngine;


public class GemCollect : MonoBehaviour
{
    public GameObject gemBurstPrefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //creating a sparkling burst
            if (gemBurstPrefab != null)
            {
                GameObject burst = Instantiate(
                    gemBurstPrefab,
                    transform.position,
                    Quaternion.identity
                );

                Destroy(burst, 2f);
            }

            //removes the gem that the capsule touched on
            Destroy(gameObject);
        }
    }
}
