using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;

    public virtual void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, GetComponent<Rigidbody2D>().velocity.y);
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    public virtual void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.collider.tag == "Projectile")
        {
            Destroy(gameObject);
            GameObject.FindWithTag("Player").GetComponent<PlayerMovement>().Score += 1;
        }
        if (collision.collider.tag == "Player")
        {
            Destroy(gameObject);
        }
        if (collision.collider.tag == "Despawn")
        {
            Destroy(gameObject);
            GameObject.FindWithTag("Player").GetComponent<PlayerMovement>().health -= 1;
        }
    }
}
