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
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float jumpPower;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] GameObject paneLose;
    [SerializeField] float rotationPower;
    [HideInInspector] public int score;
    bool isDead = false;
    public event Action OnDeath;
    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rb.velocity = Vector2.up * jumpPower; //Saut avec simple changement de la velocité : pas d'amortissement/le saut fait toujours la meme taille (le flappy bird original fonctionne de cette manière)

            //rb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse); // saut addforce (on peut amortir)
            if (!isDead) {AudioManager.Instance.PlayFly(); } // Joue un son si l'oiseau n'est pas mort

        }
        transform.rotation = Quaternion.Euler(0,0,rb.velocity.y * rotationPower); // modifie la rotation z de l'oiseau en fonction de sa vélocité y 
    }

    void Kill() // message "Kill" reçu
    {
        isDead = true;
        AudioManager.Instance.PlayDie(); // joue un son a la mort du joueur
        paneLose.SetActive(true); 
        Time.timeScale = 0; // Pause le temps
    }

    void ScoreUp()
    {
        AudioManager.Instance.PlayGainScore(); // joue un son lors de la réception du message "ScoreUp"
        score++;
        scoreText.text = "SCORE : " + score; // modifie le texte score pour l'augmenter
    }
}
