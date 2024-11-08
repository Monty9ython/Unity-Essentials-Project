using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Collectible : MonoBehaviour
{
    [SerializeField] float yRotation = 0.5f;
    [SerializeField] GameObject onCollectEffect;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, yRotation, 0);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag== "Player" )
        {
            Debug.Log("Score!!!");
            Instantiate(onCollectEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
