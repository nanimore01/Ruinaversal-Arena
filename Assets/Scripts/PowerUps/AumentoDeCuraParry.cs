using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentoDeCuraParry : Poderes
{
    public override void Comprar()
    {
        GameManagerNuevo.instance.parryCura++;
    }
}
