using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System;

public class Tuyaux : MonoBehaviour
{
    [SerializeField] float speed;

    void FixedUpdate()
    {
        gameObject.transform.Translate(Vector2.left * speed); //déplacement du tuyau en permanence vers la gauche
        if (transform.position.x <= -17) // vérifie si le tuyau a atteint un certain point
        {
            Destroy(gameObject); // il explose
        }
    }

}
