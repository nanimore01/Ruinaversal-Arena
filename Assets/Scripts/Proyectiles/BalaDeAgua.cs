using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaDeAgua : Proyectiles
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Entity>())
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
