using UnityEngine;

public class portalScript1 : MonoBehaviour
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

    private void OnTriggerEnter(Collider collision)
    {
        ball.transform.position = otherPortal.transform.position + new Vector3(0, -1.5f, 0);
        if (ball.preVolocity.y > 0)
        {
            ball.ball.linearVelocity = new Vector3(ball.preVolocity.x, -ball.preVolocity.y, 0);
        }
    }
}
