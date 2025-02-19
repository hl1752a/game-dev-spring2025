using UnityEngine;

public class gravityScript : MonoBehaviour
{
    public Rigidbody ball;

    public GameObject gDir;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ball.AddForce(gDir.transform.forward.normalized * 0.15f, ForceMode.Impulse);
    }
}
