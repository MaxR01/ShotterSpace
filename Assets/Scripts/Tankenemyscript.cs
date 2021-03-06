﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tankenemyscript : StrongEnemyScript
{
    public float enemyTankhp = 5;



    public override void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Projectile")
        {
            enemyTankhp -= 1;
        }
        if (enemyTankhp <= 0)
        {
            GameObject.FindWithTag("Player").GetComponent<PlayerMovement>().Score += 5;
            Destroy(gameObject);
        }
    }
}
