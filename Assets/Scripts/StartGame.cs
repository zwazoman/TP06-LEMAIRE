using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] GameObject startText;
    public event Action OnStart;
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            OnStart?.Invoke();
            Destroy(startText);
            Destroy(gameObject);
        }
    }
}
