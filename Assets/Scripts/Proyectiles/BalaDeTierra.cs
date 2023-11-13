using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaDeTierra : Proyectiles
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
            Destroy(gameObject);
        }
    }
}
