using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Papagaio : MonoBehaviour
{
    [SerializeField] Vector3 axis; //axis = eixo
    [SerializeField] float gravity = -20f; //Gravidade para ele cair
    [SerializeField] float force = 5f; //Força do pulo para ele subir
    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    
    void Update()
    {
        axis.y += gravity * Time.deltaTime; //para que ele caia
        transform.position += axis * Time.deltaTime; //para que ele suba

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //tecla para que ele pule
        {
            axis = Vector2.up * force; //para pular
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Obstaculos")) //para quando encostar em algum objeto nomeado como obstaculo
        {
            gameManager.GameOver(); //para acabar o jogo caso encoste
        }
        if(collision.CompareTag("Scoring")) 
        {
            gameManager.Scoring();
        }
    }
}
