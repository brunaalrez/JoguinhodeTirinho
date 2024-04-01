using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public Transform prefabEnemy;
    public Transform spawnEnemy;
    public float intervalo = 5.0f;

    void Start()
    {
        WalkEnemy();
    }

    void WalkEnemy()
    {
        Transform walk = Instantiate(prefabEnemy, spawnEnemy);
        walk.position = transform.position;
        transform.position= new Vector3((Random.Range(-3,3)), transform.position.y, transform.position.z);
        Invoke("WalkEnemy", intervalo);
    }
}
