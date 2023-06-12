using UnityEngine;
using UnityEngine.UI;

public class Node : MonoBehaviour
{
    private GameObject player;
    private eye eyeScript;
    private Node node;

    public GameObject particle;
    public AudioClip soundClip;
    public AudioSource audioSource;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        node = null;
        eyeScript = player.GetComponent<eye>();
        
    }

    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform == transform)
                    {
                        OnMouseDown();
                        
                        Instantiate(particle, transform.position, transform.rotation);
                    }
                }
            }
        }
    }

    public void OnMouseDown()
    {
        node = this;
        eyeScript.SelectNode(node);
        if (!audioSource.isPlaying)
        {
            // Define o clip do som a ser reproduzido
            audioSource.clip = soundClip;
            // Reproduz o som
            audioSource.Play();
        }
    }

    public void OnMouseUp()
    {
        node = null;
        eyeScript.DeselectNode();
        audioSource.Stop();
    }
}
