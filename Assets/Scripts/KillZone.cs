using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.SendMessage("Kill"); // envoie le message "Kill" à l'objet entrant en collision
    }
}
