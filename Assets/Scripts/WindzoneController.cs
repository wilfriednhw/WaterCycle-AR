using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WindzoneController : MonoBehaviour
{
    private WindZone windzone;
    public float speedStart = 5f;


    void Start()
    {
        windzone = GetComponent<WindZone>();
        StartCoroutine(process());
    }

    IEnumerator process()
    {
        windzone.windTurbulence = speedStart; // vitesse de départ du vent

        yield return new WaitForSeconds(4); // Attendre 4 secondes

        windzone.windTurbulence = speedStart * 2f; 

    }
}
