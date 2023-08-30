using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SemaforoIntermitente : MonoBehaviour
{
    public GameObject intermitente;
    public float apagar;

    private void Start()
    {
        StartCoroutine(Semaf());
    }
    IEnumerator Semaf()
    {
        yield return new WaitForSeconds(apagar);
        intermitente.SetActive(false);
        
        StartCoroutine(Semaf2());
    }
    IEnumerator Semaf2()
    {
        yield return new WaitForSeconds(apagar);
        intermitente.SetActive(true);
        StartCoroutine(Semaf());
    }

}
