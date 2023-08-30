using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Inicio_Paneles : MonoBehaviour
{

    public RectTransform pregunta1, pregunta2, pregunta3, pregunta4, pregunta5, pregunta6, pregunta7;


    // Start is called before the first frame update
    void Start()
    {
        pregunta1.DOAnchorPos(new Vector2(0, 0), 0);
        pregunta2.DOAnchorPos(new Vector2(0, 0), 0);
        pregunta3.DOAnchorPos(new Vector2(0, 0), 0);
        pregunta4.DOAnchorPos(new Vector2(0, 0), 0);
        pregunta5.DOAnchorPos(new Vector2(0, 0), 0);
        pregunta6.DOAnchorPos(new Vector2(0, 0), 0);
        pregunta7.DOAnchorPos(new Vector2(0, 0), 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
