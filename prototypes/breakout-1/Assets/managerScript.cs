using UnityEngine;
using System.Collections;

public class managerScript : MonoBehaviour
{
    public GameObject gDir;
    public GameObject Cam;
    public GameObject ball;
    public GameObject portal;
    public GameObject portal1;

    public float effect1;
    public float effect2;
    public float effect3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ball.GetComponent<gravityScript>().enabled = false;
        Cam.GetComponent<cameraScript>().enabled = false;
        gDir.GetComponent<MeshRenderer>().enabled = false;
        portal.GetComponent<MeshRenderer>().enabled = false;
        portal.GetComponent<BoxCollider>().enabled = false;
        portal1.GetComponent<MeshRenderer>().enabled = false;
        portal1.GetComponent<BoxCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //effect 1 timer
        if (effect1 > 0f)
        {
            gDir.GetComponent<MeshRenderer>().enabled = true;
            ball.GetComponent<gravityScript>().enabled = true;
            effect1 -= Time.deltaTime;
        }
        else
        {
            ball.GetComponent<gravityScript>().enabled = false;
            gDir.GetComponent<MeshRenderer>().enabled = false;
            effect1 = 0f;
        }

        //effect 2 timer
        if (effect2 > 0f)
        {
            effect2 -= Time.deltaTime;
            Cam.GetComponent<cameraScript>().enabled = true;
        }
        else
        {
            effect2 = 0f;
            Cam.GetComponent<cameraScript>().enabled = false;
        }

        //effect 3 timer
        if (effect3 > 0f)
        {
            portal.GetComponent<MeshRenderer>().enabled = true;
            portal.GetComponent<BoxCollider>().enabled = true;
            portal1.GetComponent<MeshRenderer>().enabled = true;
            portal1.GetComponent<BoxCollider>().enabled = true;
            effect3 -= Time.deltaTime;
        }
        else
        {
            effect3 = 0f;
            portal.GetComponent<MeshRenderer>().enabled = false;
            portal.GetComponent<BoxCollider>().enabled = false;
            portal1.GetComponent<MeshRenderer>().enabled = false;
            portal1.GetComponent<BoxCollider>().enabled = false;
        }

    }

    
}
