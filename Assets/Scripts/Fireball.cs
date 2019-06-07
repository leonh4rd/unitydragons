using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public Vector2 startVelocity;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = startVelocity;

        Destroy(gameObject, 5f);
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        var enemy = other.collider.GetComponent<Enemy>();
        enemy?.Die();
        Destroy(gameObject);
    }
}
