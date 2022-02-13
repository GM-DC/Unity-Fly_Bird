using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Tubo : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidad = 1f;
    public int direccion;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Time.deltaTime*direccion*velocidad,0,0);
    }
}
