using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    public Transform prefabBulled;
    public Transform containerTiro;
    public float intervaloTiro = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        //containerTiro = GameObject.Find("ContainerTiro").trnasform;
        Atirar();
    }


    void Atirar()
    {
        Transform tiro =Instantiate(prefabBulled, containerTiro);
        tiro.position = transform.position;
        Invoke("Atirar", intervaloTiro);
    }
}
