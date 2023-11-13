using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorretaEnemiga : EnemigosBase
{
    public Transform balaAbajo, balaArriba, balaIzquierda, balaDerecha;
    public GameObject balinAbajo, balinArriba, balinIzquierda, balinDerecha;
    public float fireRate;
    float currFireRate;
    
    
    void Start()
    {
        currFireRate = fireRate;
        aS = GetComponent<AudioSource>();
        _vida = vidaMax;
        _nombreEnemigo = "Torreta Enemiga";
    }

    void Update()
    {
        Disparos();
    }

    void Disparos()
    {
        if (currFireRate > 0)
        {
            currFireRate -= Time.deltaTime;
        }
        if (currFireRate <= 0)
        {
            Instantiate(balinAbajo, balaAbajo.position, balaAbajo.rotation);
            Instantiate(balinArriba, balaArriba.position, balaArriba.rotation);
            Instantiate(balinDerecha, balaDerecha.position, balaDerecha.rotation);
            Instantiate(balinIzquierda, balaIzquierda.position, balaIzquierda.rotation);
            currFireRate = fireRate;
        }
    }

   

    

}
