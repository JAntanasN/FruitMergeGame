using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.velocity = Vector2.zero;
            }
        }

        if (collision.gameObject.CompareTag(gameObject.tag))
        {
            Destroy(collision.gameObject);
            transform.localScale *= 2f; // Double 
        }
    }


}
