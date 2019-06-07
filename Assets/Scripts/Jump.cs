using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Jump : MonoBehaviour
{
    public Vector2 jumpForce;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GetComponent<Rigidbody2D>().AddForce(jumpForce);
            GetComponent<AudioSource>().Play();
        }
    }
}
