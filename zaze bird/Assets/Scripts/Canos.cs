using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Canos : MonoBehaviour
{
    [SerializeField] float speed = -2f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += new UnityEngine.Vector3(speed * Time.deltaTime, 0, 0); //Criar um Vetor de 3 posicoes pq o transform recebe tres eixos
        
        if(transform.position.x <= -13f)
        {
            Destroy(gameObject);
        }
    }
}
