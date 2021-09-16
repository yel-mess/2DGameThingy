using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforme : MonoBehaviour
{
    // private Transform oldParent;
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            //oldParent = collision.transform.parent;
            collision.transform.parent = transform;
        }
    }
    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            collision.transform.parent = null; //oldParent
            DontDestroyOnLoad(collision.gameObject); //ou LevelsManager
        }
    }
}
