using UnityEngine;

public class paddleScript : MonoBehaviour
{
    public float speed = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if(transform.position.x < 7.5f)
            {
                transform.Translate(speed * Time.deltaTime, 0, 0);
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > -7.5f)
            {
                transform.Translate(-speed * Time.deltaTime, 0, 0);
            }
                
        }
    }

    
}
