
using UnityEngine;

public class Particle : MonoBehaviour
{
    public float speed = 3f; //how quickly particles move tp the left

    private SpriteRenderer spriteRenderer; //accesing the partickes visuals
    private bool collected = false; //detects if particle has been collected

    private void Start() //assinging random color for the particles
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.color = new Color(
            Random.value,
            Random.value,
            Random.value
        );
    }

    private void Update() //moves the particle to the left
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }

    public void TurnWhite() //tunrs particle collor to white when collected
    {
        if (collected)
        {
            return;
        }

        collected = true;
        spriteRenderer.color = Color.white;
    }
}
