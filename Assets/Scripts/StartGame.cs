using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    GameObject startText;
    public event Action OnStart;
    void Start()
    {
        if (Input.GetKeyDown("space"))
        {
            OnStart?.Invoke();
            Destroy(startText);
            Destroy(gameObject);
        }
    }
}
