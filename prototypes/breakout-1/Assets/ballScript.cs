using UnityEngine;

public class ballScript : MonoBehaviour
{
    public Rigidbody ball;
    public Vector3 preVolocity;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ball.AddForce(5f, 5f, 0, ForceMode.Impulse);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(ball.linearVelocity.magnitude != 10f)
        {
            ball.linearVelocity = ball.linearVelocity.normalized * 10f;
        }
        preVolocity = ball.linearVelocity;
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("paddle"))
        {
            float contactX = collision.GetContact(0).point.x;
            float paddleX = collision.gameObject.transform.position.x;
            float paddleLength = collision.gameObject.transform.localScale.x;
            float paddleLeft = paddleX - paddleLength/2;
            float paddleRight = paddleX + paddleLength / 2;


            ball.linearVelocity = new Vector3(Map(contactX, paddleLeft, paddleRight, -11f, 11f), 4f, 0).normalized * preVolocity.magnitude;
            
            
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("fail"))
        {
            ball.transform.position = new Vector3(0, -6.5f, 0);
        }
    }

    public float Map(float value, float oldMin, float oldMax, float newMin, float newMax)
    {
        return newMin + (newMax - newMin) * (value - oldMin) / (oldMax - oldMin);
    }
}
