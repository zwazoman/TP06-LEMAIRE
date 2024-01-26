using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Time.timeScale = 1; // dé-pause le temps 
            SceneManager.LoadScene(0); // reload la scene 
        }
    }
}
