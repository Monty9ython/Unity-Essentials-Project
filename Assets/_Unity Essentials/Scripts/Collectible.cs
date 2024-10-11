using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Collectible : MonoBehaviour
{
    [SerializeField] float yRotation = 0.5f;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, yRotation, 0);
        scoreText.text = score.ToString();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Score!!!");
            score += score++;
            Destroy(gameObject);
        }
    }
}
