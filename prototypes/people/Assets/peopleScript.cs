using UnityEngine;

public class peopleScript : MonoBehaviour
{
    public GameObject target_mark;
    public bool isTalked = false;
    public bool isClear = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void talk()
    {
        target_mark.GetComponent<Renderer>().enabled = true;
    }
    public void leave()
    {
        target_mark.GetComponent<Renderer>().enabled = false;
    }
}
