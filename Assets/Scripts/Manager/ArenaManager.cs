using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArenaManager : MonoBehaviour
{
    public Stats stats;
    public TextoDeHistory _texto;
    public List<Stats> statsHistory = new List<Stats>();
    public int hordas = 1, EnemigosAsesinados, numeroRun;
    public SpawnerDeEnemigos spawner;
    public static ArenaManager Arena;

    private void Awake()
    {
        if (Arena == null)
        {
            Arena = this;
        }
    }

    public void Start()
    {
        spawner = FindObjectOfType<SpawnerDeEnemigos>();
        _texto = FindObjectOfType<TextoDeHistory>();
    }

    public void Update()
    {
        if (spawner == null) 
        {
            spawner = FindObjectOfType<SpawnerDeEnemigos>();
        }
    }


    public void EnemigoAsesinadoUpdate()
    {
        EnemigosAsesinados++;
        stats.enemigosAsesinadosTotal++;
        if(EnemigosAsesinados >= spawner.enemigosEnEscenaMax)
        {
            PasarHorda();
            EnemigosAsesinados = 0;
        }
    }
    public void PasarHorda()
    {
        Monedas.monedero.MonedasObtenidas(hordas);
        hordas++;
        Monedas.monedero.hitsRecibidos = 0;
        SceneManager.LoadScene(5);
        Personaje.PJ.control = Personaje.PJ.Inmovil;
    }

    
    public void MuerteArenaManager()
    {
        hordas = 1;
        EnemigosAsesinados = 0;
        Monedas.monedero.hitsRecibidos = 0;
        SceneManager.LoadScene(0);
        statsHistory.Add(stats);
        stats = new Stats();
    }

}
