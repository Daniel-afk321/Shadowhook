using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public string gameSceneName; // Nome da cena do jogo
    public string creditsSceneName; // Nome da cena dos créditos

    public void StartGame()
    {
        SceneManager.LoadScene(gameSceneName); // Carrega a cena do jogo
    }

    public void QuitGame()
    {
        Application.Quit(); // Sai do jogo
    }

    public void ShowCredits()
    {
        SceneManager.LoadScene(creditsSceneName); // Carrega a cena dos créditos
    }
}