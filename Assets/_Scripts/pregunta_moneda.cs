using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;
using System;

public class pregunta_moneda : MonoBehaviour
{
    public RectTransform preguntaParaMover;
    public GameObject preguntaParaMover2;

    public GameObject Monedita;
    GameManager gameManager;
    public RespCorrec respCorrec;
    public MoviCarPlayer CarPlayer;
    public GameObject SonidMoned;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            preguntaParaMover2.gameObject.SetActive(true);
            gameManager = GameObject.FindObjectOfType<GameManager>();
            respCorrec = GameObject.FindObjectOfType<RespCorrec>();
            preguntaParaMover.DOAnchorPos(new Vector2(-1162, 0), 0.25f);
            respCorrec.RandomSec();
            gameManager.TotalMoned();
            gameManager.PararTimer();
            Monedita.SetActive(false);
            CarPlayer.Frenar();
            SonidMoned.GetComponent<AudioSource>().Play();
        }
    }
}
