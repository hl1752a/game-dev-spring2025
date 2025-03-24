using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{
    Rigidbody2D rb;
    bool isGrounded = false;
    int jump = 2;

    float jumpPos = 0f;
    float yVolovity = 0f;

    public float speed = 1f;
    public float jumpHeight = 1f;

    public Animator anim;
    Vector2 volocity = Vector2.zero;

    public int health;
    public int maxHealth;
    public HealthBar healthBar;
    bool invincible = false;
    public SpriteRenderer ren;
    public GameObject dying;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        maxHealth = 10;
        health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -20f)
        {
            gameObject.transform.position = Vector2.zero;

            dying.gameObject.transform.localScale = new Vector3(47.8f, 23.09848f, 1);
            health = 10;
            healthBar.SetHealth(maxHealth);
        }

        float hAxis = Input.GetAxis("Horizontal");
        volocity = new Vector2(hAxis * speed * Time.fixedDeltaTime, 0);

        if (jump != 0 && Input.GetKeyDown(KeyCode.Space))
        {
            yVolovity = jumpHeight;
            jump -= 1;
            jumpPos = gameObject.transform.position.y;
        }

        if (isGrounded == false)
        {
            yVolovity += -9.81f * Time.deltaTime;
        }

        volocity.y += yVolovity;
    }


    void FixedUpdate()
    {
        rb.linearVelocity = volocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            if(gameObject.transform.position.y > collision.gameObject.transform.position.y)
            isGrounded = true;
            yVolovity = 0f;
            jump = 2;
            anim.SetBool("isJump", false);
            if (jumpPos - gameObject.transform.position.y > 6f)
            {
                int damage = 8;
                health -= damage;
                healthBar.SetHealth(health);
                StartCoroutine(HitFlash());
                for (int i = 0; i <= damage; i++)
                {
                    dying.gameObject.transform.localScale *= -0.9f;
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("heart"))
        {
            dying.gameObject.transform.localScale = new Vector3(47.8f, 23.09848f, 1);
            health = 10;
            healthBar.SetHealth(maxHealth);
        }
        else if (collision.gameObject.CompareTag("enemy"))
        {
            if (invincible == false)
            {
                invincible = true;
                int damage = 1;
                health -= damage;
                healthBar.SetHealth(health);
                StartCoroutine(HitFlash());
                for (int i = 0; i <= damage; i++)
                {
                    dying.gameObject.transform.localScale *= -0.9f;
                }
            }  
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isGrounded = false;
            anim.SetBool("isJump", true);

        }
    }

    public IEnumerator HitFlash()
    {
        invincible = true;
        for (int i = 0; i < 20; i++)
        {
            ren.enabled = false;
            yield return new WaitForSeconds(.05f);
            ren.enabled = true;
            yield return new WaitForSeconds(.05f);
        }
        invincible = false;
    }
}
