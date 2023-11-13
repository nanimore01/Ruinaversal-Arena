using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text UItexto;
    public ArenaManager arenaManager;

    
    private void Start()
    {
        arenaManager = FindObjectOfType<ArenaManager>();
        ContadorDeHordas();
    }
    void ContadorDeHordas()
    {
        UItexto.text = "Horda: " + arenaManager.hordas;
    }
}
