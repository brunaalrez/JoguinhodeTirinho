using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public Transform prefabEnemy;
    public Transform spawnEnemy;
    public float intervalo = 5.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        WalkEnemy();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void WalkEnemy()
    {
        Transform walk = Instantiate(prefabEnemy, spawnEnemy);
        walk.position = transform.position;
        Invoke("WalkEnemy", intervalo);
    }
}
