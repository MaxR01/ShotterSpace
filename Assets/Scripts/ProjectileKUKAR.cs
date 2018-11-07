using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileKUKAR : MonoBehaviour
{
    public float speed;
    // Use this for initialization
    void Start()
    {

    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("ow");
        Destroy(gameObject);
    }
}
