using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Wazo : MonoBehaviour
{
    [SerializeField] Rigidbody2D rd;
    [SerializeField] float jumpPower;
    [SerializeField] GameObject startPlatform;
    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rd.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        }
    }
}
