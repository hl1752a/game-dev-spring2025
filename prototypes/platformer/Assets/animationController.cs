using UnityEngine;

public class animationController : MonoBehaviour
{
    public SpriteRenderer ren;
    public Animator anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
        ren = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            ren.flipX = false;
            

            anim.SetBool("isWalk", true);


        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            anim.SetBool("isWalk", false);
        }


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            ren.flipX = true;
            

            anim.SetBool("isWalk", true);

        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            anim.SetBool("isWalk", false);
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            anim.SetBool("isAttack", true);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetBool("isAttack", false);
        }
    }
}
