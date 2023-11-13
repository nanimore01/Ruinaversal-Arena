using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextoDeVida : MonoBehaviour 
{
    public TMP_Text HPtext;
    public Personaje pj;

    public void Start()
    {
        VidaUpdate();
        pj.dañoRecibido += VidaUpdate;
    }
    public void VidaUpdate()
    {
        HPtext.text = pj.Vida + "/" + pj.vidaMax + " HP";
    }

   
    
}
