using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tuyaux : MonoBehaviour
{
    [SerializeField] float speed;
    void FixedUpdate()
    {
        gameObject.transform.Translate(Vector2.left * speed);
    }
}
