using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    private GameManager gameManger;
    void Start()
    {
        gameManger = FindObjectOfType<GameManager>();
    }
    public void Pausar()
    {
        gameManger.Pausa();
        gameManger.PararTimer();
        SceneManager.LoadSceneAsync("MenuPausa", LoadSceneMode.Additive);
    }
    public void Volverpausa()
    {
        gameManger.Seguir();
        gameManger.RecobrarTimer();
        SceneManager.UnloadSceneAsync("MenuPausa");
    }

    public void Volvermenu()
    {
        gameManger.RecobrarTimer();
        SceneManager.LoadScene("Menu_principal");
    }
}
