using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaylightRotation : MonoBehaviour
{
    // The duration for a day to pass (in seconds)
    [SerializeField]
    private float dayDuration = 60f; // Default to 60 seconds

    // Update is called once per frame
    void Update()
    {
        // Calculate the rotation speed based on the day duration
        float rotationSpeed = 360f / dayDuration * Time.deltaTime;

        // Rotate the light around the X-axis
        transform.Rotate(rotationSpeed, 0, 0);
    }
}
