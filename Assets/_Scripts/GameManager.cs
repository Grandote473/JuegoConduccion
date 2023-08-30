using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using TMPro;
using DG.Tweening;


public class GameManager : MonoBehaviour
{
    public Text Checking;
    public Text MultasPantalla;
    public Text RespuestasC;
    public Text RespuestasI;
    private int RespuestasCP;
    private int RespuestasIP;
    private int CheckP;
    private int Monedas;
    [SerializeField] private int TotalPreg;
    public float timer = 0;
    public TextMeshProUGUI textoTimerPro;
    public GameObject PanelFinalParaMover;
    private bool TimerActive;
    public GameObject BotonPausa;
    [SerializeField] private GameObject[] todasrespuestas;
    public GameObject[] multas;
    [SerializeField] private int multastransito;
    public GameObject SonidoChoque;
    public GameObject SonidoMulta;
    public MoviCarPlayer CarPlayer;
    void Start()
    {
        multastransito = 0;
        Monedas = 20;
        TotalPreg = 20;
        RespuestasCP = 0;
        RespuestasIP = 0;
        TimerActive = true;
    }
    void Update()
    {
        MultasPantalla.text =""+ multastransito+ "/3";
        Checking.text = "Monedas Restantes " + Monedas;
        RespuestasC.text = "Respuestas Correctas " + RespuestasCP;
        RespuestasI.text = "Respuestas Incorrectas " + RespuestasIP;
        
        textoTimerPro.text = "" + timer.ToString("f1");
        if (TimerActive == true)
        {
            timer += Time.deltaTime;
        }

        if (TotalPreg == 0)
        {
            TimerActive = false;
            PanelFinalParaMover.SetActive (true);
        }
        if (multastransito == 3)
        {
            PanelFinalParaMover.SetActive(true);
            TimerActive = false;
            CarPlayer.Frenar();
}
    }
    public void SumarMultas()
    {
        bool choq = true;
        multastransito++;
        if (choq == true)
        {
            for (int i = 0; i < multastransito; i++)
            {
                if ((multastransito - 1) == i)
                {
                    multas[i].SetActive(true);
                }
                if (i == 3)
                {
                    choq = false;
                }
            }
            SonidoChoque.GetComponent<AudioSource>().Play();
            SonidoMulta.GetComponent<AudioSource>().Play();
        }      
    }
    public void SumarCheck()
    {
        CheckP++;
    }
    public void TotalMoned()
    {
        Monedas--;
    }
    public void RespuestCorr()
    {
        RespuestasCP++;
    }
    public void RespuestasIcorr()
    {
        RespuestasIP++;
    }
    public void TotalPr()
    {
        TotalPreg--;
    }
    public void PararTimer()
    {
        
        TimerActive = false;
    }
    public void RecobrarTimer()
    {
        TimerActive = true;
    }
    public void Pausa()
    {
        BotonPausa.SetActive(false);
        TimerActive = false;
    }
    public void Seguir()
    {
        BotonPausa.SetActive(true);
        SceneManager.UnloadSceneAsync("MenuPausa", UnloadSceneOptions.None);
        TimerActive = true;
    }
    public void Reintentar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void MoverRespuestas()
    {
        todasrespuestas = GameObject.FindGameObjectsWithTag("RespuestasVarias");

        for (int i = 0; i < todasrespuestas.Length; i++){
            if (todasrespuestas[i].activeInHierarchy == true)
            {
                todasrespuestas[i].gameObject.GetComponent<RectTransform>().DOAnchorPos(new Vector2(1150, 0), 0.25f);
            }  
        }
    }
    public void MoverRespuestas2()
    {
        todasrespuestas = GameObject.FindGameObjectsWithTag("RespuestasVarias");
        for (int i = 0; i < todasrespuestas.Length; i++)
        {
            if (todasrespuestas[i].activeInHierarchy == true)
            {
                todasrespuestas[i].gameObject.GetComponent<RectTransform>().DOAnchorPos(new Vector2(0, 0), 0.25f);
            }
        }
    }
}

