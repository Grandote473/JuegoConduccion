using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UImanager : MonoBehaviour
{

    public RectTransform Menu_principal, Menu_creditos, Menu_informacion;
    


    // Start is called before the first frame update
    void Start()
    {
        Menu_principal.DOAnchorPos(Vector2.zero, 0.25f);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Info_Boton()
    {
        Menu_principal.DOAnchorPos(new Vector2(0, 2000), 0.25f);
        Menu_informacion.DOAnchorPos(new Vector2(0, 0), 0.25f).SetDelay(0.25f);
    }

    public void CloseInfo_Boton()
    {
        Menu_informacion.DOAnchorPos(new Vector2(1500, 0), 0.25f);
        Menu_principal.DOAnchorPos(new Vector2(0, 0), 0.25f).SetDelay(0.25f);
        
    }

    public void Creditos_Boton()
    {
        Menu_principal.DOAnchorPos(new Vector2(0, 2000), 0.25f);
        Menu_creditos.DOAnchorPos(new Vector2(0, 0), 0.25f).SetDelay(0.25f);
    }

    public void CloseCreditos_Boton()
    {
        Menu_creditos.DOAnchorPos(new Vector2(-1500, 0), 0.25f);
        Menu_principal.DOAnchorPos(new Vector2(0, 0), 0.25f).SetDelay(0.25f);

    }



}
