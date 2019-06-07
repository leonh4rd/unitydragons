using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField]
    private Transform fireballPrefab;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            var projectile = Instantiate(
                fireballPrefab, 
                transform.position, 
                fireballPrefab.rotation);
        }
    }
}
