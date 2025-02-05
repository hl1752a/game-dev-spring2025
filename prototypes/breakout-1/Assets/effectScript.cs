using UnityEngine;

public class effectScript : MonoBehaviour
{
    public GameObject gDir;
    public GameObject Cam;
    public GameObject ball;
    public GameObject portal;
    public GameObject portal1;

    public managerScript manager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -5f * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("paddle"))
        {
            int ram = Random.Range(1, 4);
            if (ram == 1)
            {
                manager.effect1 += 10f;
                
            }
            else if (ram == 2)
            {
                manager.effect2 += 5f;
                
            }
            else if (ram == 3)
            {
                manager.effect3 += 10f;
            }
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("fail"))
        {
            Destroy(gameObject);
        }

        
    }
}
