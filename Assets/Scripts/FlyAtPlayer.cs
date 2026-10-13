using System;
using UnityEngine;

public class PlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float speed = 20f;
    Vector3 playerPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created



    private void Awake()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        playerPosition = player.transform.position;
       
    }

    // Update is called once per frame
    void Update()
    {

        MoveToPlayer();
        DestroyWhenReachedPlayer();
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }

    void DestroyWhenReachedPlayer()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }


}
