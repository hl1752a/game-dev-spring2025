using UnityEngine;

public class brickScript : MonoBehaviour
{
    public Renderer brick;
    public ParticleSystem expl;
    public GameObject effect;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            if(brick.material.color == Color.blue)
            {
                brick.material.color = Color.green;
            }
            else if(brick.material.color == Color.green){
                int drop = Random.Range(1, 2);
                if(drop <= 2)
                {
                    Instantiate(effect, gameObject.transform.position, new Quaternion(0, 0, 0, 0));
                }
                Destroy(gameObject);
                Instantiate(expl, gameObject.transform.position, new Quaternion(0, 0, 0, 0));
            }
            else
            {
                brick.material.color = Color.blue;
            }

        }
    }
}
