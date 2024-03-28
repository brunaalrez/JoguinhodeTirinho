using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMov : MonoBehaviour
{
    float velocidade = 5f;
    Transform jogador;

    float horizontal;


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

        if (transform.position.x >= 3.5f )
        {
            transform.position = new Vector3(3.5f, transform.position.y, transform.position.z);
        }else if (transform.position.x <= -3.5f)
        {
            transform.position = new Vector3(-3.5f, transform.position.y, transform.position.z);
        }

        Vector3 movimento = new Vector3(horizontal, 0, 0);
        movimento = movimento * velocidade * Time.deltaTime;
        jogador.transform.Translate(movimento);


    }
}
