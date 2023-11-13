using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Proyectiles : MonoBehaviour
{
    public int dano;
    public float velocidad;
    [SerializeField]protected float duracionDeAtaque, influence;
    private float _tiempoAtaque;

    public virtual void Update()
    {
        EnMovimento();
        Despawneo();

    }

    protected void EnMovimento()
    {
        transform.position += transform.right * velocidad * influence * Time.deltaTime;
    }

    protected void Despawneo()
    {
        _tiempoAtaque += Time.deltaTime;

        if (_tiempoAtaque >= duracionDeAtaque)
        {
            Destroy(gameObject);
        }
    }
}
