using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Monedas : MonoBehaviour
{
    public int MonedasActuales, MonedasDadas, hitsRecibidos;
    ContadorDeHits hits;
    

    public static Monedas monedero;
    public void Start()
    {
        hits = FindObjectOfType<ContadorDeHits>();
        Personaje.PJ.dañoRecibido += HitRecibido;
        
    }
    public void Awake()
    {
        if (monedero == null)
        {
            monedero = this;
        }

    }

    public void Update()
    {
        
    }

    public void HitRecibido()
    {
        hitsRecibidos++;
        hits.UpdateHitsContador(hitsRecibidos);
    }

    
    public void MonedasObtenidas(int Oleadas)
    {
        MonedasDadas = (int)(50 * Oleadas - (hitsRecibidos * (10 / 100)));
        MonedasActuales += MonedasDadas;
        MonedasDadas = 0;
    }
}
