using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void NivelDePrueba()
    {
        SceneManager.LoadScene(2);
    }
    
    public void NivelSurvival()
    {
        SceneManager.LoadScene(1);
        ArenaManager.Arena.numeroRun++;
    }

    public void Creditos()
    {
        SceneManager.LoadScene(3);
    }

    public void MenuPrincipal()
    {
        SceneManager.LoadScene(0);
    }

    public void Controles()
    {
        SceneManager.LoadScene(4);

    }

    public void Salir()
    {
        Application.Quit();
    }
}
