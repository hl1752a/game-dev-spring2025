using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public bool atRight;
    public SpriteRenderer ren;
    public Animator anim;
    public float distance;
    public float rest;
    public int health;
    public bool isDead;


    // Start is called before the first frame update
    void Start()
    {
        ren = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        rest = -1;
        isDead = false;
        health = 5;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        rest -= Time.deltaTime;

        if (isDead is true)
        {
            Destroy(gameObject);
        }
        if (health <= 0)
        {
            anim.SetBool("isDead", true);
        }
        else
        {
            if (player.transform.position.x < transform.position.x)
            {
                ren.flipX = true;
            }
            else
            {
                ren.flipX = false;
            }



            if (distance > 13f)
            {
                anim.SetBool("isClose", false);
                anim.SetBool("isAttack", false);
                anim.SetBool("isWalk", false);
            }
            else if (distance > 5f)
            {
                if(player.transform.position.x > transform.position.x)
                {
                    transform.Translate(speed * Time.deltaTime, 0, 0);
                }
                else
                {
                    transform.Translate(-speed * Time.deltaTime, 0, 0);
                }
                anim.SetBool("isWalk", true);
                anim.SetBool("isClose", true);
                anim.SetBool("isAttack", false);

            }
            else
            {
                if (rest > 0)
                {
                    anim.SetBool("isWalk", false);
                    anim.SetBool("isAttack", false);
                }
                else
                {
                    anim.SetBool("isAttack", true);
                }

            }
        }

    }
    public void restStart()
    {
        rest = 1f;
        gameObject.GetComponent<BoxCollider2D>().size = new Vector2(1f, 1f);
    }
    public void hit()
    {
        gameObject.GetComponent<BoxCollider2D>().size = new Vector2(1.56f, 1f);
    }

    public void Die()
    {
        isDead = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player_attack"))
        {
            health -= 1;
            StartCoroutine(HitFlash());
        }
    }

    public IEnumerator HitFlash()
    {
        for (int i = 0; i < 10; i++)
        {
            ren.enabled = false;
            yield return new WaitForSeconds(.05f);
            ren.enabled = true;
            yield return new WaitForSeconds(.05f);
        }
    }

   
}
