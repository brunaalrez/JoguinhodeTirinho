using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTouch : MonoBehaviour
{
    float speed = 5f;

    void Update()
    {
        float horizontal = 0;
        if (Input.touchCount > 0)
        {
            float posicaoX = Input.GetTouch(0).position.x; //vai pegar o primeiro toque da pessoa no celular

            // CONDIÇÃO ? True : False; Operador TERNÁRIO
            horizontal = (Screen.width / 2 < posicaoX) ? -1 : 1;

        }
        Vector3 movimento = new Vector3(horizontal, 0, 0);
        movimento = movimento * speed * Time.deltaTime;

        transform.Translate(movimento);

    }
}
