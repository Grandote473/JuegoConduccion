using DG.Tweening.Core.Easing;
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrullarAuto : MonoBehaviour
{
    
    [SerializeField] private Transform[] PuntosMovimiento;
    [SerializeField] private float DistanciaMinima = 0;
    [SerializeField] public float velocid;
    [SerializeField] private float VelocidadDeMovimiento;
    private int SiguientePaso = 0;
    [SerializeField] bool frenar;
    private void Start()
    {
        frenar = true;
        VelocidadDeMovimiento = velocid;
    }
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, PuntosMovimiento[SiguientePaso].position, VelocidadDeMovimiento * Time.deltaTime);
        Vector3 dire = PuntosMovimiento[SiguientePaso].position - transform.position;
        transform.rotation = Quaternion.FromToRotation(Vector3.up, dire);
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
        }
        if (frenar == true && VelocidadDeMovimiento < velocid )
        {
            VelocidadDeMovimiento = VelocidadDeMovimiento + 0.1f;
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
