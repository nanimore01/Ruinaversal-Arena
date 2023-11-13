using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.U2D.Path.GUIFramework;
using UnityEngine;

public class Personaje : Entity
{
    public TextoDeVida txV;
    AudioSource aS;
    Personaje _pj;
    AnimacionesPersonaje _PjAnimaciones;
    Inputs _control;
    Movimiento _movement;
    
    public Pj_AtaqueMelee ataqueMelee;
    public Disparos disparos;
    
    public bool seMueve;
    public delegate void DañoRecibido();
    public event DañoRecibido dañoRecibido;

    public delegate void Control();
    public Control control;

  

    public static Personaje PJ;
    private void Awake()
    {
        if (PJ == null)
        {
            PJ = this;
        }

    }
    private void Start()
    {
        aS = GetComponent<AudioSource>();
        currVelocidad = velocidad;
        _vida = vidaMax;
        _movement = new Movimiento(transform, currVelocidad);
        _PjAnimaciones = new AnimacionesPersonaje(GetComponent<Animator>());
        _control = new Inputs(_movement, _PjAnimaciones, disparos, ataqueMelee, this);
        control = NormalMove;
        txV = FindObjectOfType<TextoDeVida>();
        txV.VidaUpdate();
        

    }
    public override void Morir()
    {
        ArenaManager.Arena.MuerteArenaManager();
        Destroy(gameObject);
    }

    public void CuracionPorParry(int cura)
    {
        _vida += cura;
        if(_vida > vidaMax)
        {
            _vida = vidaMax;
        }
        txV.VidaUpdate();
    }
    void Update()
    {
        control();
    }

    public void NormalMove()
    {
        _control.ArtificialUpdate();
    }

    public void Inmovil()
    {

    }

    
    
    public override void RecibirDano(int Dano)
    {
        base.RecibirDano(Dano);
        aS.Play();
        dañoRecibido();
    }

    public void AddMaxLife(int comprasHechas)
    {
        vidaMax += comprasHechas;
    }
    
    public void AddSpeedMovement(int comprasHechas)
    {
        velocidad += comprasHechas;
    }

}
