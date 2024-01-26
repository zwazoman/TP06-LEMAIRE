using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] StartGame _start;
    [SerializeField] Wazo wazo;
    [SerializeField] GameObject tuyaux;
    [SerializeField] Camera mainCamera;
    [SerializeField] float timeBetween = 2;
    [SerializeField] float randomMin;
    [SerializeField] float randomMax;
    bool isDone = false;

    void Start()
    {
        _start.OnStart += StartSpawnTuyaux; // réception de l'Invoke de "StartGame"

    }

    void Update()
    {
        if (!isDone) // vérifie si la condition a déjà été faite 1 fois
        {
            if (wazo.score == 20) 
            {
                AudioManager.Instance.PlayLevel(); // appelle PlayLevel dans AudioManager (singleton)
                mainCamera.backgroundColor = Color.red; // change la couleur de l'arrière plan
                timeBetween /= 1.5f; 
                isDone = true;
            }
        }
    }

    void StartSpawnTuyaux() // commence le spawn de tuyaux
    {
        StartCoroutine("SpawnTuyaux"); // lance la coroutine
    }

    IEnumerator SpawnTuyaux() //coroutine spawn des tuyaux
    {
        Instantiate(tuyaux, new Vector2(this.transform.position.x,Random.Range(randomMin,randomMax)), transform.rotation); // instanciation du prefab "tuyaux"
        yield return new WaitForSeconds(timeBetween); // attend "timeBetween" seconds
        StartSpawnTuyaux(); // rappelle la fonction commençant la coroutine afin de la faire boucler a l'infini.
    }
}
