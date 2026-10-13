using UnityEngine;

public class Scorer : MonoBehaviour
{

    int score = 0;



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
        if (collision.gameObject.tag != "Hit")
        {
            Debug.Log("You have hit this " + score++ + " many times");
        }
     
    }
}
