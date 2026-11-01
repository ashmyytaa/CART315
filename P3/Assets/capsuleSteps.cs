using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class CapsuleFootsteps : MonoBehaviour
{
    private AudioSource audioSource;
    private Rigidbody rb;
    private CharacterController cc;

    public float movementThreshold = 0.1f; 

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        bool isMoving = false;

        if (cc != null)
        {
        }
        else if (rb != null)
        {
        }
        else
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            isMoving = (h != 0 || v != 0);
        }

        if (isMoving)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}
