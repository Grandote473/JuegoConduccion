using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class RespCorrec : MonoBehaviour
{
    public RectTransform preguntaParaMover;
    GameManager manager;
    public RectTransform preguntaFood;
    public RectTransform preguntaFood2;
    public RectTransform preguntaFood3;
    private int NRandom;
    public GameObject pregunta1;
    private bool NodejarBoton;
    public MoviCarPlayer carPlayer;

    void Start()
    {
        manager = FindObjectOfType<GameManager>();
        RandomSec();
        NodejarBoton = true;
    }
    public void RandomSec()
    {

        NRandom = Random.Range(1, 4);
        if (NRandom == 1)
        {
            preguntaFood.DOAnchorPos(new Vector2(0, -300), 0f);
            preguntaFood2.DOAnchorPos(new Vector2(0, 300), 0f);
            preguntaFood3.DOAnchorPos(new Vector2(0, 0), 0f);
        }
        if (NRandom == 2)
        {
            preguntaFood.DOAnchorPos(new Vector2(0, 0), 0f);
            preguntaFood2.DOAnchorPos(new Vector2(0, -300), 0f);
            preguntaFood3.DOAnchorPos(new Vector2(0, 300), 0f);
        }
        if (NRandom == 3)
        {
            preguntaFood.DOAnchorPos(new Vector2(0, 300), 0f);
            preguntaFood2.DOAnchorPos(new Vector2(0, 0), 0f);
            preguntaFood3.DOAnchorPos(new Vector2(0, -300), 0f);
        }
        if (NRandom == 4)
        {
            NRandom = Random.Range(1, 4);
            RandomSec();
        }
    }
    public void RespuestaIncorrecta()
    {
        if (NodejarBoton == true)
        {
            NodejarBoton = false;
            manager.TotalPr();
            manager.RespuestasIcorr();
            StartCoroutine(AfterResp());
            carPlayer.Arrancar();
            pregunta1.SetActive(true);
        }      
    }
    public void RespuestaCorrecta()
    {
        if (NodejarBoton == true)
        {
            NodejarBoton = false;
            manager.TotalPr();
            manager.RespuestCorr();
            manager.SumarCheck();
            StartCoroutine(AfterResp());
            carPlayer.Arrancar();           
        }
    }
    IEnumerator AfterResp()
    {
        yield return new WaitForSeconds(0.5f);
        manager.RecobrarTimer();
        preguntaParaMover.DOAnchorPos(new Vector2(0, 0), 0.25f);
        NodejarBoton = true;
    }
}
