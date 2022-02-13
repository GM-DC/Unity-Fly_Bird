using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision_Tubo_Limite : MonoBehaviour
{

    public int rangoInferior;
    public int rangoSuperior;


    private void OnCollisionEnter2D(Collision2D objeto) {
        if (objeto.gameObject.name=="Limite")
        {
            transform.position = new Vector3(10,Random.Range(rangoInferior,rangoSuperior),0);
        }

        if (objeto.gameObject.name=="Ave")
        {
            Destroy(objeto.gameObject);
        }
    }

}
