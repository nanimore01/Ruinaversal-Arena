using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaTorretaEnemiga : Proyectiles
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Personaje>())
        {
            Destroy(gameObject);
            collision.GetComponent<Entity>().RecibirDano(dano);
        }
        if (collision.gameObject.GetComponent<AtaqueMeleePJ>())
        {
            collision.GetComponent<AtaqueMeleePJ>().CuracionVoid();
            Destroy(gameObject);
        }
    }



}
