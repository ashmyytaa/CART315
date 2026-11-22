
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class CapsuleFootsteps : MonoBehaviour{
    private AudioSource audioSource;
    private Vector3 lastPosition;
    public float movementThreshold = 0.1f;

    void Start(){
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true;
        lastPosition = transform.position;
    }

    void Update(){
        Vector3 movement = transform.position - lastPosition;
        movement.y = 0f;

        float speed = movement.magnitude / Mathf.Max(Time.deltaTime, 0.0001f);
        bool isMoving = speed > movementThreshold;

        if (isMoving){
            if (!audioSource.isPlaying) {
                audioSource.Play();
            }
        }
        else{
            if (audioSource.isPlaying){
                audioSource.Stop();
            }
        }
        lastPosition = transform.position;
    }
}