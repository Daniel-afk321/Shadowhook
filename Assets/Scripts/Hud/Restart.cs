using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void RestartGame()
    {
        Time.timeScale = 1f; // Reseta a escala do tempo para continuar o jogo
        SceneManager.LoadScene("Game");
    }

    public void ReturnToMenu()
    {
        Time.timeScale = 1f; // Reseta a escala do tempo para continuar o jogo
        SceneManager.LoadScene("Menu"); // Carrega a cena do menu principal (substitua "MenuScene" pelo nome da sua cena do menu principal)
    }
}
