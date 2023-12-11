using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class PopupRegras : MonoBehaviour
{
    int currentPage;
    bool isOpen;

    [SerializeField] private GameObject btnOpen;
    [SerializeField] private GameObject btnClose;
    [SerializeField] private GameObject btnRight;
    [SerializeField] private GameObject btnLeft;
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject panelBlur;
    [SerializeField] private Text panelText;
    
    const string TEXT_PAGE_1 = "1. O jogo consiste em 10 rodadas.\r\n\r\n2. cada jogador tem 3 chancs em cada rodada para pontuar atraves de combinacoes de dados.\r\n\r\n3. Ao final de cada rodada, os pontos sao armazenados em uma tabela que contem as pontuacoes comuns e especiais.\r\n\r\n4. ao final , soma-se os pontos e quem possuir maior pontuacao ganha.";
    const string TEXT_PAGE_2 = "sequencia \r\n\r\nVALE 20 PONTOS\r\nEX.12345 OU 23456 OU 34561\r\n\r\nFULA\r\n\r\nCONSISTE EM 3 DADOS DE MESMO VALOR E UMA DUPLA DE OUTRO\r\nVALE 30 PONTOS\r\nEX 33322\r\n\r\npoker\r\n\r\n4 DADOS IGUAIS\r\nVALE 40 PONTOS\r\nEX 44441";
    const string TEXT_PAGE_3 = "general\r\n\r\n5 dados iguais\r\nvale 50 pontos\r\nex 66666\r\n\r\nnumeros\r\n\r\nsoma-se o valor dos dados com mesmo numero\r\nex 22246, marca-se 2+2+2 = 6 \r\nno quadrante 2";

    const int MAXLIMIT_SCREEN = 3;
    const int MINLIMIT_SCREEN = 1;

    void Start()
    {
        // Setting var
        this.panel.SetActive(false);
        this.panelBlur.SetActive(false);
        isOpen = false;
        currentPage = 1;

        btnOpen.GetComponent<Button>().onClick.AddListener(() =>
        {
            if (!isOpen)
            {
                this.panel.SetActive(true);
                this.panelBlur.SetActive(true);
                isOpen = true;
            }
        });

        btnClose.GetComponent<Button>().onClick.AddListener(() =>
        {
            if (isOpen)
            {
                this.panel.SetActive(false);
                this.panelBlur.SetActive(false);
                isOpen = false;
            }
        });

        btnRight.GetComponent<Button>().onClick.AddListener(() =>
        {
            nextPage();
        });

        btnLeft.GetComponent<Button>().onClick.AddListener(() =>
        {
            previousPage();
        });



    }

    void nextPage()
    {
        if (currentPage + 1 <= MAXLIMIT_SCREEN)
        {
            currentPage++;
            getText(currentPage);
        }
    }

    void previousPage()
    {
        if (currentPage - 1 >= MINLIMIT_SCREEN)
        {
            currentPage--;
            getText(currentPage);
        }
    }

    void getText(int index)
    {
        try
        {
            if(index < 1 || index > MAXLIMIT_SCREEN)
            {
                throw new UnityException("Index inválido.");
            }

            switch (index)
            {
                case 1:
                    panelText.GetComponent<Text>().text = TEXT_PAGE_1;
                    break;
                case 2:
                    panelText.GetComponent<Text>().text = TEXT_PAGE_2;
                    break;
                case 3:
                    panelText.GetComponent<Text>().text = TEXT_PAGE_3;
                    break;
                default:
                    throw new UnityException("Deu um erro no qual não explicar!");
            }
        }
        catch(UnityException err)
        {
            throw err;
        }
    }




}
