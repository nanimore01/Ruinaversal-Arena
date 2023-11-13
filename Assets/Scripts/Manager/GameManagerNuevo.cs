using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManagerNuevo : MonoBehaviour
{
    public static GameManagerNuevo instance;
    public Dictionary<string, int> EnemigosLista = new Dictionary<string, int>();
    public int vidaMax, velocidad, balaVelocidad, parryCura;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    public void Kill(string EnemigoAsesinado)
    {
        if (EnemigosLista.ContainsKey(EnemigoAsesinado))
            EnemigosLista[EnemigoAsesinado]++;
        else
            EnemigosLista.Add(EnemigoAsesinado, 1);
    }
    
    
    
}
