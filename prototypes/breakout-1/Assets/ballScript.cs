using UnityEngine;

public class ballScript : MonoBehaviour
{
    public Rigidbody ball;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ball.AddForce(5f, 5f, 0, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("brick"))
        {
            Destroy(collision.gameObject);
        }
    }
}
