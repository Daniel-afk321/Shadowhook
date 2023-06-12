using UnityEngine;

public class SoundOnTrigger : MonoBehaviour
{
    public AudioClip soundClip;
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        // Verifica se o objeto colidido � o jogador
        if (other.CompareTag("Armadilha"))
        {
            // Verifica se o som j� est� sendo reproduzido
            if (!audioSource.isPlaying)
            {
                // Define o clip do som a ser reproduzido
                audioSource.clip = soundClip;
                // Reproduz o som
                audioSource.Play();
            }
        }
    }
}
