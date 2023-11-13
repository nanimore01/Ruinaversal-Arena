using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoBomba : EnemigosBase
{
    float currSpeed;
    private void Awake()
    {
        PlayerPos = Personaje.PJ.transform;
        aS = GetComponent<AudioSource>();
        _nombreEnemigo = "Enemigo Bomba";
    }
    void Start()
    {
        currSpeed = velocidad;
        _vida = vidaMax;
    }
    void Update()
    {
        if (Personaje.PJ.seMueve == false)
        {
            Vector3 dir = (PlayerPos.position - transform.position).normalized;
            transform.position += dir * currSpeed * Time.deltaTime;
        }
    }
    
    void OnTriggerEnter2D(Collider2D AtaqueMeleePJ)
    {
        if (AtaqueMeleePJ.gameObject.CompareTag("Player"))
        {
            AtaqueMeleePJ.GetComponent<Entity>().RecibirDano(dano);
            aS.Play();
            Morir();

        }
    }
}
