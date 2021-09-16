using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void Load(string destination) {
        SceneManager.LoadScene(destination);
    }
    public void Quit () {
        Application.Quit();
    }
}
