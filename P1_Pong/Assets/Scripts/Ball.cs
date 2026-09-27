using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigidBody;

    public float speed = 100.0f;
        public GameObject onCollectEffect;


    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Start()
{
    AddStartingForce();
}

    public void ResetBall()
    {
        _rigidBody.linearVelocity = Vector2.zero;
    _rigidBody.angularVelocity = 0;
        transform.position = Vector3.zero;
    }

    public void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = (Random.value < 0.5f ? -1.0f : 1.0f) * Random.Range(0.5f, 0.9f);

        Vector2 direction = new Vector2(x, y);

        _rigidBody.AddForce(direction * speed);
            _rigidBody.angularVelocity = 360.0f;

    }


private void OnCollisionEnter2D(Collision2D collision)
{
    Paddle paddle = collision.gameObject.GetComponent<Paddle>();

    if (paddle != null)
    {
        ContactPoint2D contact = collision.GetContact(0);

        GameObject effect = Instantiate(
            onCollectEffect,
            contact.point,
            Quaternion.identity
        );

        ParticleSystem particles = effect.GetComponent<ParticleSystem>();

        if (particles != null)
        {
            particles.Play();
        }
    }
}


}