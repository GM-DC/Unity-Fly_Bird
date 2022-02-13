using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision_Nube_Limite : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D objeto) {
        if (objeto.gameObject.name=="Limite")
        {
            transform.position = new Vector3(10,Random.Range(-4,4),0);
        }
    }

}
