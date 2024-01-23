using System.Collections;
using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.Mathematics;

public class Wazo : MonoBehaviour
{
    [SerializeField] Rigidbody2D rd;
    [SerializeField] float jumpPower;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] GameObject paneLose;
    [SerializeField] float rotationPower;
    int score;
    public event Action OnDeath;
    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rd.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse); //saut 
        }
        this.transform.rotation = Quaternion.Euler(0,0,rd.velocity.y * rotationPower);
    }

    void Kill()
    {
        //message "Kill" reçu
        paneLose.SetActive(true);
        Time.timeScale = 0; // Pause le temps
    }

    void ScoreUp()
    {        
        print("AUGMENTE");
        score++;
        scoreText.text = "SCORE : " + score;
    }
}
