using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrongEnemyScript : EnemyMovement
{
    public float enemyhp = 2;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
    }

    public override void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Despawn")
        {
            Destroy(gameObject);
            GameObject.FindWithTag("Player").GetComponent<PlayerMovement>().health -= 2;
        }
        if (collision.collider.tag == "Player")
        {
            Destroy(gameObject);
        }
        if (collision.collider.tag == "Projectile")
        {
            enemyhp -= 1;
        }
        if (enemyhp <= 0)
        {
            GameObject.FindWithTag("Player").GetComponent<PlayerMovement>().Score += 2;
            Destroy(gameObject);
        }
    }
}
