using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int hordas = 1, armaNumero, golpesRecibidos, monedasActuales, vidaMax, vidaCuradaPorParry;
    public float speed, speedBullet;
    
    public PJ personaje;
    public Tienda shop;

    void Start()
    {
        personaje = GameObject.Find("PJ").GetComponent<PJ>();

        golpesRecibidos = personaje.golpesRecibidos;

    }
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        
    }
    void Update()
    {
        
    }
    
   
}
