using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentoDeVelocidad : Poderes
{
    public override void Comprar()
    {
        if (Monedas.monedero.MonedasActuales > precio)
        {
            Monedas.monedero.MonedasActuales -= precio;
            
            Personaje.PJ.AddSpeedMovement(1);

        }
    }

}
