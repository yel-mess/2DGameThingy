using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIUpdater : MonoBehaviour
{
    public Image[] lifeImages;
    void Start()
    {
        
    }

    void Update()
    {
        for(int index = 0; index < lifeImages.Length; index++) {
            lifeImages[index].enabled = index < LevelsManager.lifes;
        }
    }
}
