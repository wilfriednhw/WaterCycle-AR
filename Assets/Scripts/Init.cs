using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Init : MonoBehaviour
{
    public GameObject island;
    public GameObject buttonPause;

    // public GameObject buttonPlay;
    // public GameObject dialog;
    // private DialogController dialogController;

    void Start()
    {
        island.SetActive(false); // Cacher l'ile

        buttonPause.SetActive(false);   // Cacher le bouton pause

        Time.timeScale = 0;
    }

    void Update()
    {
        
    }
}
