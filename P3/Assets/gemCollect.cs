using UnityEngine;

public class GemCollect : MonoBehaviour{

    public GameObject gemBurstPrefab;
    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            if (gemBurstPrefab != null){

                Camera cam = Camera.main;
                Vector3 burstPosition = transform.position;

                if (cam != null){
                    burstPosition = cam.transform.position + cam.transform.forward * 4f;
                }

                GameObject burst = Instantiate(
                    gemBurstPrefab,
                    burstPosition,
                    Quaternion.identity
                );
                Destroy(burst, 3f);
            }
            Destroy(gameObject);
        }
    }
}