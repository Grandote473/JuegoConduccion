using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reintentar : MonoBehaviour
{
    // Start is called before the first frame update
    public void Reintentarr()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
