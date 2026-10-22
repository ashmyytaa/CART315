using UnityEngine;

public class Player : MonoBehaviour
{
    public float strength = 5f; //controls how high the player goes up
    public float gravity = -9.81f; //pull down of player
    public float tilt = 5f;

    private Vector3 direction;

    private void OnEnable() //put to 0 player position when game starts
    {
        Vector3 position = transform.position;
        position.y = 0f;
        transform.position = position;
        direction = Vector3.zero;
    }

    private void Update() //check if player presses Space or mouse button
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up * strength; //adds stregnth and gravity to player
        }

        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;

          if (transform.position.y > 4.5f) //player boucnes of canvas when y > 4.5f
        {
            direction.y = -Mathf.Abs(direction.y);
        }

        if (transform.position.y < -4.5f) //player bounces off canvas when y < -4.5f
        {
            direction.y = Mathf.Abs(direction.y);
        }

        Vector3 rotation = transform.eulerAngles; //rotation applied to vertical movement aka tilting
        rotation.z = direction.y * tilt;
        transform.eulerAngles = rotation;
    }

 private void OnTriggerEnter2D(Collider2D other) //detects when player touches particles
{
    Particle particle = other.GetComponent<Particle>(); //check if the touched componene is actually particle component

    if (particle != null)
    {
        particle.TurnWhite(); //turns the particle white

        GameManager.Instance.IncreaseScore(); //score increase by 1
    }
}
}