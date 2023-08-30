using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrullar : MonoBehaviour
{
    [SerializeField] private float VelocidadDeMovimiento;
    [SerializeField] private Transform[] PuntosMovimiento;
    [SerializeField] private float DistanciaMinima;
    [SerializeField] bool frenar;
    [SerializeField] public float velocid;
    public GameObject caminar;
    private int SiguientePaso = 0;
    private void Start()
    {
        frenar = true;
        VelocidadDeMovimiento = velocid;
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, PuntosMovimiento[SiguientePaso].position, VelocidadDeMovimiento * Time.deltaTime);
        Vector3 dire = PuntosMovimiento[SiguientePaso].position - transform.position;
        transform.rotation = Quaternion.FromToRotation(Vector3.left, dire);
        if (Vector2.Distance(transform.position, PuntosMovimiento[SiguientePaso].position) < DistanciaMinima)
        {            
            SiguientePaso++;
            if (SiguientePaso >= PuntosMovimiento.Length)
            {
                SiguientePaso = 0;
            }           
        }
        if (frenar == false && VelocidadDeMovimiento > 0.1)
        {
            VelocidadDeMovimiento = VelocidadDeMovimiento - 0.1f;
            caminar.GetComponent<Animator>().enabled = false;
        }
        if (frenar == true && VelocidadDeMovimiento < velocid)
        {
            VelocidadDeMovimiento = VelocidadDeMovimiento + 0.1f;
            caminar.GetComponent<Animator>().enabled = true;
        }
    }
    public void velo()
    {
        frenar = false;        
    }
    public void Reset()
    {
        frenar = true;        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            velo();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Reset();
        }
    }


}
