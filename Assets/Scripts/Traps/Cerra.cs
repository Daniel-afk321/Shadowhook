using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cerra : MonoBehaviour
{
    public Transform pointA; // Primeiro ponto
    public Transform pointB; // Segundo ponto
    public float speed = 2f; // Velocidade de movimento

    private Vector3 targetPosition; // Posição de destino atual

    void Start()
    {
        // Inicializa a posição de destino no primeiro ponto
        targetPosition = pointA.position;
    }

    void Update()
    {
        // Move o objeto em direção à posição de destino
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // Verifica se o objeto chegou ao ponto de destino
        if (transform.position == targetPosition)
        {
            // Alterna o ponto de destino entre pointA e pointB
            if (targetPosition == pointA.position)
                targetPosition = pointB.position;
            else
                targetPosition = pointA.position;
        }
    }
}