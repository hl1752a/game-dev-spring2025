using UnityEngine;

public class backgroundScript : MonoBehaviour
{
    public GameObject Camera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Camera.transform.position.x, 0f, 0f);
    }
    
}
