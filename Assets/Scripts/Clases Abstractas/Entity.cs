using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    public int vidaMax;
    public float velocidad;
    protected int _vida;
    public int Vida
    {
        get { return _vida; }
    }
    protected float currVelocidad;
    [SerializeField] protected int dano;
    
    public virtual void RecibirDano(int Dano)
    {
        _vida -= Dano;
        if(_vida < 0)
        {
            Morir();
        }
    }

    public abstract void Morir();

    public virtual void RecibirCura(int Cura)
    {
        _vida += Cura;
        if(_vida > vidaMax)
        {
            _vida = vidaMax;
        }
    }

    


}
