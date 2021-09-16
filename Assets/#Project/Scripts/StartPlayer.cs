using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlayer : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        //GameObject.FindObjectOfType<LevelsManager>().player.transform.position = transform.position; //va chercher la première instance. FindObjectsOfType en cherche plusieurs

        LevelsManager levelsManager = LevelsManager.instance;
        GameObject player = levelsManager.player;
        player.transform.position = transform.position;
    }
}
