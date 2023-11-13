using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs 
{
    AnimacionesPersonaje _animacionesPersonaje;
    Movimiento _movement;
    Disparos _disparos;
    Pj_AtaqueMelee _pj_AtaqueMelee;
    Personaje _pj;
    
    public Inputs(Movimiento movement, AnimacionesPersonaje animacionesPersonaje, Disparos disparos, Pj_AtaqueMelee pj_AtaqueMelee, Personaje personaje)
    {
        _movement = movement;
        _animacionesPersonaje = animacionesPersonaje;
        _disparos = disparos;
        _pj_AtaqueMelee = pj_AtaqueMelee;
        _pj = personaje;
    }

    public void ArtificialUpdate()
    {
        float v = Input.GetAxisRaw("Vertical");
        float h = Input.GetAxisRaw("Horizontal");
        if (Input.GetMouseButton(1)) _disparos.DisparoPorDefecto();
        if (Input.GetMouseButton(0)) _pj_AtaqueMelee.AtaqueMelee();

        if (h != 0 || v != 0)
            _pj.seMueve = true;
        else _pj.seMueve = false;

        
        _movement.Move(v, h);
        _animacionesPersonaje.AnimacionesDeMovimiento(v, h);
    }
}
