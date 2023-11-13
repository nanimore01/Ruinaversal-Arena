using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueMeleePJ : Proyectiles
{
    public int cura = 1;
    
    private void Start()
    {
        
    }
    public override void Update()
    {
        Despawneo();
    }
    public void CuracionVoid()
    {
        Personaje.PJ.CuracionPorParry(cura);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var stuneable = collision.GetComponent<EnemigosBase>();
        
        if (stuneable != null)
        {

            collision.GetComponent<EnemigosBase>().RecibirDano(dano);
            collision.GetComponent<EnemigosBase>().SoundAtaque();
            Destroy(gameObject);
        }
    }


}
