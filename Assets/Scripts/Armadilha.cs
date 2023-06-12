using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armadilha : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject playerDeathVFX;
    public GameObject player;

    
    public AudioSource audioSource;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Armadilha"))
        {
            // Time.timeScale = 0f; // Congela o jogo
            audioSource.Play();
            player.SetActive(false);
            Instantiate(playerDeathVFX, player.transform.position, Quaternion.identity);
            gameOverPanel.SetActive(true); // Ativa o painel de Game Over
           
           

        }
    }
}
