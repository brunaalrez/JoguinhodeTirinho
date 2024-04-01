using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5f;
    public float tempoVida = 3.0f;
    public WalkEnemy WalkEnemy;
    public AdvanceUpgrate AdvanceUpgrate;

    void Start()
    {
        Invoke("DestruirBala", tempoVida);
    }

    void Update()
    {
        
    }

    void DestruirBala()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy") 
        {
            other.transform.GetComponent<WalkEnemy>().verificarMorte();
        }
        else if(other.gameObject.tag == "Upgrade")
        {
            other.transform.GetComponent<AdvanceUpgrate>().verificarMorte();
        }
    }
}
