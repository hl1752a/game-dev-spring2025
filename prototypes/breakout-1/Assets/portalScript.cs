using UnityEngine;

public class portalScript : MonoBehaviour
{
    public ballScript ball;
    public GameObject otherPortal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(ball.preVolocity.y > 0)
        {
            ball.transform.position = otherPortal.transform.position + new Vector3(0, 1.5f, 0);
        }
        else
        {
            ball.transform.position = otherPortal.transform.position - new Vector3(0, 1.5f, 0);
        }
        ball.ball.linearVelocity = new Vector3(ball.preVolocity.x, -ball.preVolocity.x, 0);
    }
}
