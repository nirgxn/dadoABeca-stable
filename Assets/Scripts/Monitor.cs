using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monitor
{
    public int nroCliqueRolar_btn;
    public int nroCliqueManter_btn;
    GameObject[] gameObject = new GameObject[10];

    public Monitor(GameObject[] __gameObjects)
    {
        this.nroCliqueManter_btn = 0;
        this.nroCliqueRolar_btn = 0;
        this.gameObject = __gameObjects;
    }

    public Monitor exportToAnotherClass()
    {
        return new Monitor(this.gameObject);
    }

    public void setGameObjectOnce(GameObject[] __obj)
    {
        this.gameObject = __obj;
    }

    public void resetCounting()
    {
        this.nroCliqueRolar_btn = 0;
        this.nroCliqueManter_btn = 0;
    }

    public void showData()
    {
        Debug.Log("NROROLAR:" + nroCliqueRolar_btn);
        Debug.Log("NROMANTER:" + nroCliqueManter_btn);
    }

}