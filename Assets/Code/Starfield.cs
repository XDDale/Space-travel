using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starfield: MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<Xwing>().speed = 4;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<Xwing>().speed = 2;
    }
}