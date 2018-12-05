using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrongEnemyScript : EnemyMovement
{
    public float enemyhp = 2;

    public override void OnCollisionEnter2D(Collision2D collision)
    {
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
