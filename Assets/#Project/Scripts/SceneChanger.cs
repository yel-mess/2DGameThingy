using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public bool isOpen = true;

    public Sprite doorOpen;
    public Sprite doorClosed;

    private void Start() {
        if (isOpen) {
            GetComponent<SpriteRenderer>().sprite = doorOpen;
        }
        else {
            GetComponent<SpriteRenderer>().sprite = doorClosed;
        }
    }
    public string sceneName;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && isOpen)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
    public void Unlock() {
        isOpen = true;
        GetComponent<SpriteRenderer>().sprite = doorOpen;
        Debug.Log("Door is open");
    }
}
