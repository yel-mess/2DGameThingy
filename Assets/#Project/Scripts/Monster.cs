using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]// pour mettre les composant directement
[RequireComponent(typeof(BoxCollider2D))]
public class Monster : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) {
        
        if (collision.CompareTag("Player")) {
            LevelsManager.LoseLife();
        }
    }
}
