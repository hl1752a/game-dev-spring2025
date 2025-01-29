using UnityEngine;

public class cameraScript : MonoBehaviour
{
    public GameObject paddle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (paddle.transform.position.x < 7.5f)
            {
                transform.Rotate(0, 0, 360f * Time.deltaTime);
            }
                
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (paddle.transform.position.x > -7.5f)
            {
                transform.Rotate(0, 0, -360f * Time.deltaTime);
            }
        }
    }
}
