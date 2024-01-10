using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceControlledMovement : MonoBehaviour
{
    public float speed = 5f; 
    private bool isMoving = false;

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isMoving = true;
        }

        
        if (Input.GetKeyUp(KeyCode.Space))
        {
            isMoving = false;
        }

        
        if (isMoving)
        {
            
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        else
        {
           
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
    }
}
