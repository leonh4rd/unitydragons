using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragonKiller : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if(transform.position.y > 6f || transform.position.y < -5.6f)
        {
            SceneManager.LoadScene(0);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        SceneManager.LoadScene(0);
    }
}
