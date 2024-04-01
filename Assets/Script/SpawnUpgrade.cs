using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnUpgrade : MonoBehaviour
{
    public Transform prefabUpgrade;
    public Transform spawnUpgrade;
    public float intervalo = 7f;

    void Start()
    {
        Avancar();
    }

    void Update()
    {
        
    }

    void Avancar()
    {
        Transform avancar = Instantiate(prefabUpgrade, spawnUpgrade);
        avancar.position = transform.position;
        transform.position = new Vector3((Random.Range(-3, 3)), transform.position.y, transform.position.z);
        Invoke("Avancar", intervalo);
    }
}
