using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] StartGame _start;
    [SerializeField] GameObject tuyaux;
    [SerializeField] float time = 2;
    void Start()
    {
        _start.OnStart += StartSpawnTuyaux;
    }

    void StartSpawnTuyaux()
    {
        StartCoroutine("SpawnTuyaux");
    }

    IEnumerator SpawnTuyaux()
    {

        yield return new WaitForSeconds(time);
    }
}
