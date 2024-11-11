using UnityEngine;

public class WalkSounds : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if(collision.transform.CompareTag("Grass"))
        {
            Debug.Log("Entering Grass");
        }
    }

    void OnTriggerExit(Collider collision)
    {
        if(collision.transform.CompareTag("Grass"))
        {
            Debug.Log("Exiting Grass");
        }
    }
}
