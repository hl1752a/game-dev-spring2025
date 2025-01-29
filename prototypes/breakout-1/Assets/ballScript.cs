using UnityEngine;

public class ballScript : MonoBehaviour
{
    public Rigidbody ball;
    public Vector3 preVolocity;

    public GameObject gDir;
    public ParticleSystem expl;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ball.linearVelocity = ball.linearVelocity.normalized * 15f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(ball.linearVelocity.magnitude != 10f)
        {
            ball.linearVelocity = ball.linearVelocity.normalized * 10f;
        }
        preVolocity = ball.linearVelocity;
        ball.AddForce(gDir.transform.forward.normalized * 0.15f, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("brick"))
        {
            Destroy(collision.gameObject);
            Instantiate(expl, collision.gameObject.transform.position,new Quaternion(0,0,0,0));
        }

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
    public float Map(float value, float oldMin, float oldMax, float newMin, float newMax)
    {
        return newMin + (newMax - newMin) * (value - oldMin) / (oldMax - oldMin);
    }
}
