using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] StartGame _start;
    [SerializeField] Wazo wazo;
    [SerializeField] GameObject tuyaux;
    [SerializeField] float timeBetween = 2;
    [SerializeField] float randomMin;
    [SerializeField] float randomMax;
    bool isDivided = true;

    void Start()
    {
        _start.OnStart += StartSpawnTuyaux;

    }

    void Update()
    {
        if (isDivided)
        {
            if (wazo.score == 20)
            {
                AudioManager.Instance.PlayLevel();
                timeBetween /= 1.5f;
                isDivided = false;
            }
        }
    }

    void StartSpawnTuyaux() // commence le spawn de tuyaux
    {
        StartCoroutine("SpawnTuyaux");
    }

    IEnumerator SpawnTuyaux() //coroutine spawn des tuyaux
    {
        Instantiate(tuyaux, new Vector2(this.transform.position.x,Random.Range(randomMin,randomMax)), this.transform.rotation);
        yield return new WaitForSeconds(timeBetween);
        StartSpawnTuyaux();
    }
}
