using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkEnemy : MonoBehaviour
{
    public float speed = 50.0f;
    public int vida = 3;

    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    public void verificarMorte()
    {
        vida--;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}

