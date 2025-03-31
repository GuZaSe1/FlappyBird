using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    [SerializeField] float speedTexture;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(speedTexture * Time.deltaTime, 0); //Para atualizar o movimento do fundo pelo eixo 'X';
    }
}
