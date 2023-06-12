using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public string gameSceneName; // Nome da cena do jogo
    public string creditsSceneName; // Nome da cena dos cr�ditos
    public AudioSource audioSource;
    public void StartGame()
    {
        audioSource.Play();
        SceneManager.LoadScene(gameSceneName); // Carrega a cena do jogo
    }

    public void QuitGame()
    {
        audioSource.Play();
        Application.Quit(); // Sai do jogo
    }

    public void ShowCredits()
    {
        audioSource.Play();
        SceneManager.LoadScene(creditsSceneName); // Carrega a cena dos cr�ditos
    }
}