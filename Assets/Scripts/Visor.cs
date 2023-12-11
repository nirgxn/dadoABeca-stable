
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/*
 
    0 - P1
    1 - P2
    2 - p3
    3 - P4
    4 - p5
    5 - P6
    6 - Sequencia
    7 - Fula
    8 - Poker
    9 - General
   
 
 
 */
public class Visor
{
    public GameObject[] getGameObjects;
    public Monitor monitor;
    System.Random rand;
    public int somaPontos;
    List<int> numerosSorteados = new List<int>();


    public Visor()
    {
        numerosSorteados.Clear();
        getGameObjects = new GameObject[10];
        monitor = new Monitor(getGameObjects);
        somaPontos = 0;
    }
    public void addGameObjects(GameObject[] __getGameObjects)
    {
       for(int i = 0; i < __getGameObjects.Length; i++)
        {
            getGameObjects[i] = __getGameObjects[i];
        }
        monitor.setGameObjectOnce(__getGameObjects);
    }

    public void changePontos(int index,int valor)
    {

        if (getGameObjects[0].GetComponent<Text>().text == "1" && index == 0            ||
            getGameObjects[1]. GetComponent<Text>().text == "2" && index == 1              ||
            getGameObjects[2].GetComponent<Text>().text == "3" && index == 2            ||
            getGameObjects[3].GetComponent<Text>().text == "4" && index == 3            ||
            getGameObjects[4].GetComponent<Text>().text == "5" && index == 4            ||
            getGameObjects[5].GetComponent<Text>().text == "6" && index == 5            ||
            getGameObjects[6].GetComponent<Text>().text == "sequencia" && index == 6    ||
            getGameObjects[7].GetComponent<Text>().text == "fula" && index == 7         ||
            getGameObjects[8].GetComponent<Text>().text == "poker" && index == 8        ||
            getGameObjects[9].GetComponent<Text>().text == "general" && index == 9 )
        {
            getGameObjects[index].GetComponent<Text>().text = valor.ToString();
            getGameObjects[index].GetComponent<Text>().color = Color.white;
        }
    }

    public void modificarNaoPontuacao()
    {
        rand = new System.Random();
        int numeroAleatório;

        do
        {
            numeroAleatório = rand.Next(0, 6);
            if (numerosSorteados.Count == 6)
            {
                numerosSorteados.Clear();
            }
        }
        while (numerosSorteados.Contains(numeroAleatório));
        
       

        getGameObjects[numeroAleatório].GetComponent<Text>().text = "x";
        getGameObjects[numeroAleatório].GetComponent<Text>().color = Color.white;
    }

    public void resetVisor()
    {
        getGameObjects[0].GetComponent<Text>().text = "1";
        getGameObjects[1].GetComponent<Text>().text = "2";
        getGameObjects[2].GetComponent<Text>().text = "3";
        getGameObjects[3].GetComponent<Text>().text = "4";
        getGameObjects[4].GetComponent<Text>().text = "5";
        getGameObjects[5].GetComponent<Text>().text = "6";
        getGameObjects[6].GetComponent<Text>().text = "sequencia";
        getGameObjects[7].GetComponent<Text>().text = "fula";
        getGameObjects[8].GetComponent<Text>().text ="poker";
        getGameObjects[9].GetComponent<Text>().text = "general";
    }

};