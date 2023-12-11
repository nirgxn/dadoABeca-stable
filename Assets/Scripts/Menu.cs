using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    Animator animator = new Animator();
    void Start()
    {
        Invoke("Inicia",2.0f);
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        if (Input.anyKeyDown || Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2))
        {

            SceneManager.LoadScene("GeralScene");
        }

    }

    public void Inicia()
    {
        animator.SetTrigger("Comecou");

    }
}
