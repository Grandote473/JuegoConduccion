using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultaChoque : MonoBehaviour
{
    public GameManager gameManager;
    private bool salir;
    void Start()
    {
        salir = true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        {
            if (collision.gameObject.tag == "Player")
            {
                if (salir)
                {
                    gameManager.SumarMultas();
                    salir = false;
                }
            }
        }        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        {
            if (collision.gameObject.tag == "Player")
            {
                StartCoroutine(boleana());
            }
        }
    }
    IEnumerator boleana()
    {
        yield return new WaitForSeconds(2);
        salir = true;
    }
}
