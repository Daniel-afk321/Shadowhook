using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armadilha : MonoBehaviour
{
    public GameObject gameOverPanel;

     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Armadilha"))
        {
            Time.timeScale = 0f; // Congela o jogo
            gameOverPanel.SetActive(true); // Ativa o painel de Game Over
        }
    }
}
