using UnityEngine;

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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -20f)
        {
            gameObject.transform.position = Vector2.zero;
        }
        float hAxis = Input.GetAxis("Horizontal");
        volocity = new Vector2(hAxis * speed * Time.deltaTime, 0);
        
        if(jump != 0 && Input.GetKeyDown(KeyCode.Space))
        {
            yVolovity = jumpHeight;
            jump -= 1;
            jumpPos = gameObject.transform.position.y;
        }
        
        if(isGrounded == false)
        {
            yVolovity += -9.81f * Time.deltaTime;
        }
        
        volocity.y += yVolovity;

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
                Debug.Log("fall damage");
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
}
