using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroyOnTouch : MonoBehaviour
{
    public UnityEvent whenPickUP;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            whenPickUP?.Invoke();
            Destroy(gameObject);
        }
    }
}
