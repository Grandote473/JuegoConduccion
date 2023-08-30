using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SemaforoNormal : MonoBehaviour
{
    public GameObject primeraLuz;
    public GameObject segundaLuz;
    public GameObject terceraLuz;
    public float primero;
    public float segundo;
    public float tercero;
    void Start()
    {
        primeraLuz.SetActive(true);
        StartCoroutine(trafficlight());
    }
    IEnumerator trafficlight()
    {
        while (true)
        {
            yield return new WaitForSeconds(primero);
            primeraLuz.SetActive(false);
            segundaLuz.SetActive(true);
            yield return new WaitForSeconds(segundo);
            segundaLuz.SetActive(false);
            terceraLuz.SetActive(true);
            yield return new WaitForSeconds(tercero);
            terceraLuz.SetActive(false);
            primeraLuz.SetActive(true);
        }
    }
}
