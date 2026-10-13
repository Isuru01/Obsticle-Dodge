using UnityEngine;

public class Dropper : MonoBehaviour
{
    float startTime = 0f;
    [SerializeField] float timeToWait = 5f;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidBody;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startTime = Time.timeSinceLevelLoad;
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidBody = GetComponent<Rigidbody>();

        myMeshRenderer.enabled = false;
        myRigidBody.useGravity = false;

        Debug.Log("Look Out!");
    }

    // Update is called once per frame
    void Update()
    {
        float elapsedTime = Time.timeSinceLevelLoad - startTime;
        //Debug.Log("Time spent: " + elapsedTime.ToString("F2") + " seconds");

        if (elapsedTime > timeToWait)
        {
           
            myMeshRenderer.enabled = true;
            myRigidBody.useGravity = true;
        }
    }
}
