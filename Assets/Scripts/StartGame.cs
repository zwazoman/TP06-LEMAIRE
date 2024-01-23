using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] GameObject startText;
    [SerializeField] GameObject musicMetal;
    public event Action OnStart;
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            OnStart?.Invoke();
            musicMetal.SetActive(true);
            AudioManager.Instance.PlayStart();
            Destroy(startText);
            Destroy(gameObject);
        }
    }
}
