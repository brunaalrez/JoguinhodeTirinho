using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadWall : MonoBehaviour
{
    public void colicao(Collider collider)
    {
        if (collider.gameObject.tag == "Enemy")
        {
            collider.transform.GetComponent<ControllerMov>().lifePlayer();
            
        }
    }
}
