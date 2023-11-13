using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextoDeStats : MonoBehaviour
{
    [SerializeField] TMP_Text _text;
    

    private void Start()
    {
        
    }
    
    public void UpdateStats()
    {
        foreach (var item in GameManagerNuevo.instance.EnemigosLista)
        {
            _text.text = "Destrozaste a un " + item.Key + " " + item.Value + " veces en total";
        }
    }
    

    
}
