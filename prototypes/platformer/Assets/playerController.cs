using UnityEngine;

public class playerController : MonoBehaviour
{
    Rigidbody2D rb;
    bool isGrounded = false;
    int jump = 2;

    public float speed = 1f;
    public float yVolovity = 0f;

    Vector2 volocity = Vector2.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        volocity = new Vector2(hAxis * speed * Time.deltaTime, 0);
        
        if(jump != 0 && Input.GetKeyDown(KeyCode.Space))
        {
            yVolovity = 5f;
            jump -= 1; 
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
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isGrounded = false;
        }
    }
}
