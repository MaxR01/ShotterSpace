using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public Transform Firepoint;
    public GameObject Projectile;
    public float timer;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Instantiate(Projectile, Firepoint.position, Firepoint.rotation);
            }
            timer = 0.1f;
        }
    }
}
