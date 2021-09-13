using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforme : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            collision.transform.parent = transform;
        }
    }
    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            collision.transform.parent = null;
        }
    }
}
