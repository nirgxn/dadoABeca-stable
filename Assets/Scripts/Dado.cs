using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Dado : MonoBehaviour,
    IPointerDownHandler
{
    bool clicado;
    public int qntd;
    private Vector3 posicaoOriginal;
    private Vector3 posicaoFinal;
 

    private void Start()
    {

        //controla dado clicado
        //clicado = manter = false;
        this.gameObject.GetComponent<BoxCollider2D>().autoTiling = true;
        this.clicado = false;
        posicaoOriginal = new Vector3(1.0f,1.0f,1.0f);
        posicaoFinal = new Vector3(1.2f,1.2f,1.2f);

    }
    public void resetAll()
    {
        this.clicado = false;
        this.gameObject.GetComponent<RectTransform>().localScale = posicaoOriginal;
    }

    public void resetAnimacao()
    {
        this.gameObject.GetComponent<RectTransform>().localScale = posicaoOriginal;
    }

    public void setValor(int valor)
    {
        this.qntd = valor;
    }


    public bool getClicado()
    {
        return this.clicado;
    }

    public void setClicado(bool status)
    {
        this.clicado = status;
    }

    public void zerarDados()
    {    

        this.clicado = false;
    }

    public void getLogDado()
    {
      
       Debug.Log("Clicado:" + this.clicado);
    }

    private void OnMouseEnter()
    {

        if (!clicado)
        {
            this.gameObject.GetComponent<RectTransform>().localScale = posicaoFinal;

        }

    }

    private void OnMouseExit()
    {

        if (!clicado)
        {
            //diminui dado com clique do mouse
            this.gameObject.GetComponent<RectTransform>().localScale = posicaoOriginal;
        }

    }

    public void OnPointerDown(PointerEventData eventData) // Quando clicar em cima
    {
        if (Input.GetMouseButtonDown(0))
        {
            clicado = !clicado; //false
           // this.getLogDado();

            if (clicado)
            {
                //aumenta
                this.gameObject.GetComponent<RectTransform>().localScale = posicaoFinal;

            }
            else
            {
                //diminui
                this.gameObject.GetComponent<RectTransform>().localScale = posicaoOriginal;

            }
        }
    }

    public void atualizarAnimacao()
    {
        if (clicado)
        {
            //aumenta
            this.gameObject.GetComponent<RectTransform>().localScale = posicaoFinal;

        }
        else
        {
            //diminui
            this.gameObject.GetComponent<RectTransform>().localScale = posicaoOriginal;

        }
    }

    public void resetar()
    {
        this.Start();
    }
}
