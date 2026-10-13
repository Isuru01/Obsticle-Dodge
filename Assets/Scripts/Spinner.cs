using System;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField]float xAngleValue = 0f;
    [SerializeField]float yAngleValue = 1f;
    [SerializeField]float zAngleValue = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngleValue, yAngleValue, zAngleValue);
        
    }



}
