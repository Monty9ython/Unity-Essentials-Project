using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// Controls player movement and rotation.
public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f; // Set player's movement speed.
    public float rotationSpeed = 120.0f; // Set player's rotation speed.

    [SerializeField] int playerScore;
    [SerializeField] TMP_Text scoreText;

    private Rigidbody rb; // Reference to player's Rigidbody.

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>(); // Access player's Rigidbody.
    }

    // Update is called once per frame
    void Update()
    {
        updateScoreUI();
    }


    // Handle physics-based movement and rotation.
    private void FixedUpdate()
    {
        // Move player based on vertical input.
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = transform.forward * moveVertical * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);

        // Rotate player based on horizontal input.
        float turn = Input.GetAxis("Horizontal") * rotationSpeed * Time.fixedDeltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);
    }
    
    //updates the UI elements that the player needs to influence
    void updateScoreUI()
    {
        scoreText.text= Convert.ToString(playerScore);
    }

    //method to increment the player's score
    void scoreIncrement()
    {
        playerScore += 1;
    }
    void scoreDecrement()
    {
        playerScore -= 1;
    }

    //checks whether the player collides with any GameObject that has the tag 'Collectible'
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            scoreIncrement();
        }
        else if (other.CompareTag("Furniture"))
        {
            Debug.Log("Ouch!");
            scoreDecrement();
        }
    }

}
