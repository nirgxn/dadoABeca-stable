using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RedirecionarParaACena : MonoBehaviour
{
    // Considerando que você vai adicionar isso em um botão
    [SerializeField]private string nomeDaCena;

    private void Start()
    {

        this.gameObject.GetComponent<Button>().onClick.AddListener(() =>
        {
            SceneManager.LoadScene(nomeDaCena);
        });
    }
}
