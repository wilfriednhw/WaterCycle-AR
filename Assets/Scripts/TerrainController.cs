using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainController : MonoBehaviour
{
    void Start()
    {
      
    }

    void Update()
    {

    }

    public void hideTerrain() {
        gameObject.SetActive(false);
    }

    public void showTerrain() {
        gameObject.SetActive(true);
    }
}
