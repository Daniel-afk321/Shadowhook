using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    public GameObject victoryPanel;
    public GameObject player;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("A"))
        {
            // Time.timeScale = 0f; // Congela o jogo
            player.SetActive(false);
           
            victoryPanel.SetActive(true); // Ativa o painel de Game Over
        }
    }
}
