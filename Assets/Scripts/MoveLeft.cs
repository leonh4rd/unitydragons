using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float moveSpeed = 1f;

    private void OnEnable() {
        ShowRandomSprite();
    }

    void Update()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        if(transform.position.x < -10)
        {
            transform.position += Vector3.right * 25f;
            ShowRandomSprite();
        }
    }

    private void ShowRandomSprite()
    {
        int index = Random.Range(0, 3);
        int childCount = transform.childCount;

        for(int i = 0; i < childCount; i++)
        {
            Transform child = transform.GetChild(i);
            child.gameObject.SetActive(index == i);
        }
    }
}
