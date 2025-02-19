using UnityEngine;

public class gDirScript : MonoBehaviour
{
    public GameObject paddle;
    public GameObject cam;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cam.GetComponent<cameraScript>().enabled == true)
        {

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (paddle.transform.position.x < 8.35f)
            {
                transform.Rotate(360f * Time.deltaTime, 0, 0);
            }

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (paddle.transform.position.x > -8.35f)
            {
                transform.Rotate(-360f * Time.deltaTime, 0, 0);
            }
        }
    }
}
