using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SaberDadoClicado : MonoBehaviour
{
    [SerializeField]private string string_dado;
    private static string string_para_comunicar;
    private static bool dadoClicado_para_comunicar;


    private void Start()
    {
        dadoClicado_para_comunicar = false;
        string_para_comunicar = string_dado;
        //evento d clique
        this.gameObject.GetComponent<Button>().onClick.AddListener(delegate ()
        {
            //inverte estado com clique
            dadoClicado_para_comunicar = !dadoClicado_para_comunicar;

            //Debug.Log("Estado do dado:" + dadoClicado_para_comunicar + "\nQual dado:" + string_dado);
        });
    }

   public static string receberStringDado()
   {
        return string_para_comunicar;
   }

    public static bool receberEstadoDado()
    {
        return dadoClicado_para_comunicar;
    }

    public static void zerarDados()
    {
        dadoClicado_para_comunicar = false;
    }

}   
