using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterController : MonoBehaviour
{
    public float speed = 6f;

    public string step; // Ceci permet de connaitre dans quelle étape on se trouve

    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime, Space.Self);

        // Represente l'absorbtion de l'eau par la terre
        if (string.Equals(step.ToLower(), "infiltration"))
        {
            float y_target = -1.32f; // La position Y que l'eau doit dépasser pour arreter la translation sur l'axe Y.

            if (transform.position.y > y_target )
            {
                Vector3 coord_waterUnderGround = new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z);
                float speed = 0.2f;
                transform.position = Vector3.Lerp(transform.position, coord_waterUnderGround, Time.deltaTime * speed);
            }
        }
    }
}
