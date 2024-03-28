using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5f;
    public float tempoVida = 3.0f;
 

    void Start()
    {
        Invoke("DestruirBala", tempoVida);
    }

    void Update()
    {
        transform.Translate(0, 0, -(speed * Time.deltaTime));
    }

    void DestruirBala()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy") 
        {
            Destroy(other.gameObject);
        }
    }
}
