using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentoDeVida : Poderes
{
    public override void Comprar()
    {
        if (Monedas.monedero.MonedasActuales > precio && limiteDeCompras > GameManagerNuevo.instance.vidaMax)
        {
            Monedas.monedero.MonedasActuales -= precio;
            ArenaManager.Arena.stats.monedasGastadas += precio;
            GameManagerNuevo.instance.vidaMax++;
            Personaje.PJ.AddMaxLife(1);
        }
    }
}
