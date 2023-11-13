using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ContadorDeHits : MonoBehaviour
{
    public TMP_Text hits;
    
    public void UpdateHitsContador(int HitsRecibidos)
    {
        hits.text = "Hits Recibidos: " + HitsRecibidos;
    }
}
