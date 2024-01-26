using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] GameObject startText;
    [SerializeField] GameObject musicMetal;
    public event Action OnStart; // création de l'évènement "OnStart"
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            OnStart?.Invoke(); // appel de l'évènement
            musicMetal.SetActive(true); 
            AudioManager.Instance.PlayStart(); // appelle la fonction "PlayStart()" de l'AudioManager (singleton)
            Destroy(startText);
            Destroy(gameObject);
        }
    }
}
