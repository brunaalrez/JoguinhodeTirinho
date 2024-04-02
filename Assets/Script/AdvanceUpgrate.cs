using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvanceUpgrate : MonoBehaviour
{
    public float speed = 5f;
    public int tempo = 7;

    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    public void verificarMorte()
    {
        tempo--;
        if (tempo <= 0)
        {
            PlayerShooter.intervaloTiro -= 0.2f;
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
