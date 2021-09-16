using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsManager : MonoBehaviour
{
    public static LevelsManager instance = null; // static = si elle est modifiée toutes les autres instance seront modifiés aussi
    public GameObject playerPrefab;
    public GameObject player;
    public static int lifes = 3;
    void Start()
    {
        if (instance == null) {
            DontDestroyOnLoad(gameObject); //le gameObject sur lequel est ce script
            instance = this;
            player = Instantiate(playerPrefab);
            DontDestroyOnLoad(player);

        }
        else {
            Destroy(gameObject);
        }
    }

    public static void LoseLife() {
        lifes--;
        if (lifes <= 0) {
            SceneManager.LoadScene("GameOver");
        }
        else {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
