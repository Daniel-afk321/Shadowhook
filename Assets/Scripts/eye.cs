using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eye : MonoBehaviour
{
    private LineRenderer LineRend;
    private DistanceJoint2D distJoint;
    private Node selectedNode;
    //Move
    public float speed;
    //Jump
    public float JumpSpeed = 5;
    bool isGrounded;
    bool canDoubleJump;
    public float delayBeforeDoubleJump;
    private Rigidbody2D rb;
    private AudioSource audioSource;
    public AudioClip jumpSound;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        LineRend = GetComponent<LineRenderer>();
        distJoint = GetComponent<DistanceJoint2D>();
        LineRend.enabled = false;
        distJoint.enabled = false;
        selectedNode = null;
        audioSource = GetComponent<AudioSource>();
    }

   
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        NodeBehavior();
    }

    public void SelectNode(Node node)
    {
        selectedNode = node;
    }

    public void DeselectNode()
    {
        selectedNode = null;
    }

    private void NodeBehavior()
    {
        if (selectedNode == null)
        {
            LineRend.enabled = false;
            distJoint.enabled = false;

            return;
        }

        LineRend.enabled = true;
        distJoint.enabled = true;

        distJoint.connectedBody = selectedNode.GetComponent<Rigidbody2D>();

        if (selectedNode != null)
        {
            LineRend.SetPosition(0,transform.position);
            LineRend.SetPosition(1,selectedNode.transform.position);
        }

    }

     void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = true;
            canDoubleJump = false;
        }
    }

    public void jumpButton()
    {
        if (isGrounded)
        {
            isGrounded = false;
            rb.velocity = Vector2.up * JumpSpeed;
            Invoke("EnableDoubleJump", delayBeforeDoubleJump);
            audioSource.PlayOneShot(jumpSound);
        }
        if (canDoubleJump)
        {
            rb.velocity = Vector2.up * JumpSpeed;
            canDoubleJump = false;
            
        }
    }

    void EnableDoubleJump()
    {
        canDoubleJump = true;
        //audioSource.PlayOneShot(jumpSound);
    }

}
