using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionesPersonaje
{
    Animator playerAnimator;
    
    public AnimacionesPersonaje(Animator PJanimacion)
    {
        playerAnimator = PJanimacion;
        
    }
    
    public void AnimacionesDeMovimiento(float x , float y)
    {
        
        playerAnimator.SetFloat("Horizontal", x);
        playerAnimator.SetFloat("Vertical", y);
    }
}
