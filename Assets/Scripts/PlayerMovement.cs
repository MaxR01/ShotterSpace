using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public TextMeshProUGUI HpText;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI DeadText;
    public Canvas DeadCanvas;
    public float speed;
    // Use this for initialization
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        health = 10;
        Score = 0;
    }
    public float speed1;
    public Transform Firepoint;
    public GameObject Projectile;
    private SpriteRenderer sprite;
    public int health;
    public int Score;
    public float timer;

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Instantiate(Projectile, Firepoint.position, Firepoint.rotation);
            }
            timer = 0.14f;
        }
        HpText.text = "Health: " + health;
        ScoreText.text = "Score: " + Score;
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, speed1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, -speed1);
        }
        if (health <= 0)
        {
            Destroy(gameObject);
            DeadText.text = "You died with a score of " + Score;
            DeadCanvas.gameObject.SetActive(true);
            Time.timeScale= 0;
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Enemy")
        {
            Destroy(collision.collider.gameObject);
            health -= 1;
        }
        if (collision.collider.tag == "EnemyTank")
        {
            Destroy(collision.collider.gameObject);
            health -= 4;
        }
        if (collision.collider.tag == "EnemyStrong")
        {
            Destroy(collision.collider.gameObject);
            health -= 2;
        }
    }

}
