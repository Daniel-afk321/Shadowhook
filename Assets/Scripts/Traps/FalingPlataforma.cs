using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalingPlataforma : MonoBehaviour
{
    private float fallDelay = 1f;
    private float destroyDelay = 3f;
    private AudioSource audioSource;
    public AudioClip terra;
    [SerializeField] private Rigidbody2D rb;

     void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Fall());
        }
    }

    private IEnumerator Fall()
    {
        audioSource.PlayOneShot(terra);
        yield return new WaitForSeconds(fallDelay);
        rb.bodyType = RigidbodyType2D.Dynamic;
        Destroy(gameObject, destroyDelay);
    }
}
