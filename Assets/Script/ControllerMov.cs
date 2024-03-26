using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMov : MonoBehaviour
{
    float velocidade = 5f;
    Transform jogador;

    float horizontal;
    public float limiteEsquerdo = 3.13f;
    public float limiteDireito = -3.41f;
    // Start is called before the first frame update
    void Start()
    {
        jogador = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            horizontal = 1;
        }
        else if (Input.GetKey(KeyCode.RightArrow)) 
        { 
            horizontal = -1; 
        }
        else
        {
            horizontal = 0;
        }
        Vector3 movimento = new Vector3(horizontal, 0, 0);
        movimento = movimento * velocidade * Time.deltaTime;

        jogador.transform.Translate(movimento);

    }
}
