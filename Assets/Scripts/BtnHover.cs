using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BtnHover : MonoBehaviour
{

    private Vector3 posicaoOriginal;
    private Vector3 posicaoFinal;

    private void Start()
    {
        this.gameObject.GetComponent<BoxCollider2D>().autoTiling = true;
        posicaoFinal = new Vector3(1.05f, 1.05f, 1.05f);
        posicaoOriginal = new Vector3(1.0f, 1.0f, 1.0f);
    }
    private void OnMouseEnter()
    {
        this.gameObject.GetComponent<RectTransform>().localScale = posicaoFinal;

    }
    private void OnMouseExit()
    {
        this.gameObject.GetComponent<RectTransform>().localScale = posicaoOriginal;

    }

}
