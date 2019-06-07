using UnityEngine;

public class Enemy : MonoBehaviour
{
    public void Die()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<PolygonCollider2D>().enabled = false;
    }

    public void Respawn()
    {
        GetComponent<SpriteRenderer>().enabled = true;
        GetComponent<PolygonCollider2D>().enabled = true;
    }
}
