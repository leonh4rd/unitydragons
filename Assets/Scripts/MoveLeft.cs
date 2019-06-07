using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float moveSpeed = 1f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        if(transform.position.x < -15)
        {
            transform.position += Vector3.right * 30f;
        }
    }
}
