using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextoDeHistory : MonoBehaviour
{
    [SerializeField] TMP_Text _textoDeEnemigos;
    [SerializeField] TMP_Text _textoDeMonedas;

    public void Start()
    {
        _textoDeEnemigos.text = "Enemigos destruidos en esta run: " + ArenaManager.Arena.statsHistory[ArenaManager.Arena.numeroRun].enemigosAsesinadosTotal;
        _textoDeMonedas.text = "Monedas gastadas en esta run: " + ArenaManager.Arena.statsHistory[ArenaManager.Arena.numeroRun].monedasGastadas;
    }

    
}
