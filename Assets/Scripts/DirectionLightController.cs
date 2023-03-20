using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionLightController : MonoBehaviour
{
    private Light sun;
    private float rotation;
    public float factor = 5;
    private Quaternion Night = new Quaternion(1f, -1f, 1f, -1f);


    // Start is called before the first frame update
    void Start()
    {
       sun = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        // 1  Changer la direction du soleil progressivement vers un coté un peu plus sombre
        sun.transform.rotation = Quaternion.Lerp(sun.transform.rotation, Night, Time.deltaTime / factor);
    }
}
