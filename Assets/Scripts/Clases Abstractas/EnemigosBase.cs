using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemigosBase : Entity, IStuneable
{
    public Transform PlayerPos;
    protected string _nombreEnemigo;
    [SerializeField] protected float viewDistance;
    protected AudioSource aS;
    public bool sePuedeMover = true;

    public void SoundAtaque()
    {
        aS.Play();
    }
    public override void Morir()
    {
        ArenaManager.Arena.EnemigoAsesinadoUpdate();
        GameManagerNuevo.instance.Kill(_nombreEnemigo);
        ArenaManager.Arena.stats.enemigosAsesinadosTotal++;
        Destroy(gameObject);
    }
    public void Stun()
    {
        StartCoroutine(Stunned(2));
    }

    public IEnumerator Stunned(float Tiempo)
    {
        sePuedeMover = !sePuedeMover;
        yield return new WaitForSeconds(Tiempo);
        sePuedeMover = !sePuedeMover;

    }

}
