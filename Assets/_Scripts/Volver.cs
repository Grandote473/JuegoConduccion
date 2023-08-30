using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class Volver : MonoBehaviour
{
    public RectTransform panel_respesta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void volverPanel()
    {
        panel_respesta.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }
}
