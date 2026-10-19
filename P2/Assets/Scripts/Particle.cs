
using UnityEngine;

public class Particle : MonoBehaviour
{
    public float speed = 3f;

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.color = new Color(
            Random.value,
            Random.value,
            Random.value
        );
    }

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }

    public void TurnWhite()
    {
        spriteRenderer.color = Color.white;
    }
}
