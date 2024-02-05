using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comet : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(0, -1, 0); 
    public float speed = 5f; 

    private bool shouldMove = false;

    public void StartMoving()
    {
        shouldMove = true;
    }

    void Update()
    {
        if (shouldMove)
        {
            transform.Translate(moveDirection * speed * Time.deltaTime);
        }
    }
}