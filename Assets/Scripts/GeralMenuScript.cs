using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeralMenuScript : MonoBehaviour
{
    public void AbreJogo()
    {
        SceneManager.LoadScene("jogoRodando");
    }
    public void AbreRegras() 
    {
        SceneManager.LoadScene("RegrasScene");
    }

    public void FechaJogo() 
    {
        Application.Quit();
    }
}

