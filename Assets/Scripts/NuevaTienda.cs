using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NuevaTienda : MonoBehaviour
{
    public Poderes[] poder;
    public TextoDeStats estadisticas;
    private void Start()
    {
        Personaje.PJ.control = Personaje.PJ.Inmovil;
        estadisticas.UpdateStats();
    }
    public void ComprarPoderes(int index)
    {
        poder[index].Comprar();
    }
    public void AlSurvival()
    {
        SceneManager.LoadScene(1);
        Personaje.PJ.control = Personaje.PJ.NormalMove;
    }
    
}
