using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalManager : MonoBehaviour
{
    [SerializeField] private GameObject jogo;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelOpcoes;
    public void Jogar()
    {
        jogo.SetActive(true);
    }

    public void AbrirOpcoes()
    {
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);

    }

    public void FecharOpcoes()
    {
        painelOpcoes.SetActive(false);
        painelMenuInicial.SetActive(true);
    }

    public void VoltarMenu()
    {
        jogo.SetActive(false);
        painelMenuInicial.SetActive(true);
    }
    public void SairJogo()
    {
        Debug.Log("sair do jogo");
        Application.Quit();
    }
}
