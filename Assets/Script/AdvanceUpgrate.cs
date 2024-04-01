using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvanceUpgrate : MonoBehaviour
{
    public float speed = 5f;
    public int vida = 7;

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
}
