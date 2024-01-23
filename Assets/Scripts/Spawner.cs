using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] StartGame _start;
    [SerializeField] Wazo _stop;
    [SerializeField] GameObject tuyaux;
    [SerializeField] float time = 2;
    [SerializeField] float randomMin;
    [SerializeField] float randomMax;
    void Start()
    {
        _start.OnStart += StartSpawnTuyaux;
        //_stop.OnDeath += StopSpawnTuyaux; //event mort du joueur
    }
    //commence le spawn de tuyaux
    void StartSpawnTuyaux()
    {
        StartCoroutine("SpawnTuyaux");
    }

    //stoppe le spawn de tuayx
    /*void StopSpawnTuyaux()
    {
        StopCoroutine("SpawnTuyaux");
    }*/

    //coroutine spawn des tuyaux
    IEnumerator SpawnTuyaux()
    {
        Instantiate(tuyaux, new Vector2(this.transform.position.x,Random.Range(randomMin,randomMax)), this.transform.rotation);
        yield return new WaitForSeconds(time);
        StartSpawnTuyaux();
    }
}
