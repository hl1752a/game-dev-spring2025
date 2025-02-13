using UnityEngine;
using TMPro;

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

    public TMP_Text timer1;
    public TMP_Text timer2;
    public TMP_Text timer3;

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

        timer1.GetComponent<CanvasRenderer>().SetAlpha(0f);
        timer2.GetComponent<CanvasRenderer>().SetAlpha(0f);
        timer3.GetComponent<CanvasRenderer>().SetAlpha(0f);


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
            timer1.GetComponent<CanvasRenderer>().SetAlpha(255f);
            timer1.text = string.Format("gravity control: " + effect1);
        }
        else
        {
            ball.GetComponent<gravityScript>().enabled = false;
            gDir.GetComponent<MeshRenderer>().enabled = false;
            effect1 = 0f;
            timer1.GetComponent<CanvasRenderer>().SetAlpha(0f);
        }

        //effect 2 timer
        if (effect2 > 0f)
        {
            effect2 -= Time.deltaTime;
            Cam.GetComponent<cameraScript>().enabled = true;
            timer2.GetComponent<CanvasRenderer>().SetAlpha(255f);
            timer2.text = string.Format("camera rotate: " + effect2);
        }
        else
        {
            effect2 = 0f;
            Cam.GetComponent<cameraScript>().enabled = false;
            timer2.GetComponent<CanvasRenderer>().SetAlpha(0f);
        }

        //effect 3 timer
        if (effect3 > 0f)
        {
            portal.GetComponent<MeshRenderer>().enabled = true;
            portal.GetComponent<BoxCollider>().enabled = true;
            portal1.GetComponent<MeshRenderer>().enabled = true;
            portal1.GetComponent<BoxCollider>().enabled = true;
            effect3 -= Time.deltaTime;
            timer3.GetComponent<CanvasRenderer>().SetAlpha(255f);
            timer3.text = string.Format("portal: " + effect3);
        }
        else
        {
            effect3 = 0f;
            portal.GetComponent<MeshRenderer>().enabled = false;
            portal.GetComponent<BoxCollider>().enabled = false;
            portal1.GetComponent<MeshRenderer>().enabled = false;
            portal1.GetComponent<BoxCollider>().enabled = false;
            timer3.GetComponent<CanvasRenderer>().SetAlpha(0f);
        }

    }

    
}
