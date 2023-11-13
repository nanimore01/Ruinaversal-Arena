using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionEnemiga : MonoBehaviour
{
    public float duracionDeAtaque;
    float tiempoAtaque;
    void Start()
    {
        tiempoAtaque += Time.deltaTime;

        if (tiempoAtaque >= duracionDeAtaque)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
