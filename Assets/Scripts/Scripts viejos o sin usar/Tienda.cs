using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tienda : MonoBehaviour
{
    public int monedasDadas;
    public PJ personaje;
    public SpawnerDeEnemigos spawner;
    public GameManager GM;
    public Text tx;

    public Poderes[] poder;
    

    void Start()
    {
        personaje = GameObject.Find("PJ").GetComponent<PJ>();
        
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
        CalculoDeMonedas();
       
    }

    // Update is called once per frame
    void Update()
    {

        
        ContadorDeMonedas();

    }

    

    public void CalculoDeMonedas()
    {
        monedasDadas = (GM.hordas * 25) - (GM.golpesRecibidos * 2);

        

        if (monedasDadas < 0)
        {
            monedasDadas = 0;
        }
        GM.monedasActuales += monedasDadas;
    }
    public void ContadorDeMonedas()
    {

        tx.text = "" + GM.monedasActuales.ToString();

    }

    

    
    
    
    public void SiguienteHorda()
    {
        SceneManager.LoadScene(1);
        
    }
}
