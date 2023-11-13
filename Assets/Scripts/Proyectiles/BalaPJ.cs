using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaPJ : Proyectiles
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        var stuneable = collider.GetComponent<IStuneable>();
        if (stuneable != null)
        {
            collider.GetComponent<EnemigosBase>().SoundAtaque();
            collider.GetComponent<EnemigosBase>().RecibirDano(dano);
            stuneable.Stun();
            Destroy(gameObject);
        }
    }
}
