using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;


public class Panel_Respuest : MonoBehaviour
{
    public RectTransform RepuestaParaMover;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MoverResp()
    {
        RepuestaParaMover.DOAnchorPos(new Vector2(1162, 0), 0.25f);
    }
}
