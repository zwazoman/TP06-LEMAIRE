using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SendMessage("ScoreUp"); // envoie le message "ScoreUp" � l'objet entrant dans le trigger
    }

}
