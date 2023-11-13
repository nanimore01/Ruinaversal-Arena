using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonedasContador : MonoBehaviour
{
    public Text tx;
    
    public void Start()
    {
        
        UpdateText();
    }

    public void UpdateText()
    {
        var MonedasActuales = Monedas.monedero.MonedasActuales;
        tx.text = MonedasActuales + "$";
    }
    
    

    
}
