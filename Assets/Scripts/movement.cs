using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackwardMovement : MonoBehaviour
{
    public float speed = 5f; // Adjust the speed as needed
    private Vector3 initialPosition;
    public float lowerOffset = 4f; // Adjust the lower offset as needed

    void Start()
    {
        // Store the initial position when the script starts
        initialPosition = transform.position;
    }

    void Update()
    {
        // Move the object backward in the local z-axis
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }

    void OnBecameInvisible()
    {
        // Randomly decide whether to apply a lower offset or not
        bool respawnLower = Random.Range(0, 2) == 0;

        // Calculate the respawn position based on the random decision
        Vector3 respawnPosition = respawnLower ? GetLowerPosition() : initialPosition;

        // When the object goes out of the view, respawn it at the calculated position
        transform.position = respawnPosition;
    }

    Vector3 GetLowerPosition()
    {
        // Calculate the respawn position slightly lower than the initial position
        return new Vector3(initialPosition.x, initialPosition.y - lowerOffset, initialPosition.z);
    }
}
