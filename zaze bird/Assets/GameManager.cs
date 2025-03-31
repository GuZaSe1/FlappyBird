using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //MANIPULAR OS OBJETOS DE UI
using UnityEngine.SceneManagement; ///manipular cenas

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] int score;
    [SerializeField] private GameObject GameOverObj;
    [SerializeField] private GameObject startObj;

    void Start()
    {
        Time.timeScale = 0; //para o jogo começar parado
        startObj.SetActive(true);
    }
    public void StartButton()
    {
        Time.timeScale = 1; //para quando iniciar o jogo ele andar
        GameOverObj.SetActive(false); //Desativar o botao de game over
        startObj.SetActive(false); //desatiavar o start
    }
 
    void Update()
    {
        scoreText.text = score.ToString(); //usei o tostring para que o o score apareça como texto, ja que ele é tipo int

    }
    public void GameOver()
    {
        GameOverObj.SetActive(true); //para que aconteça o game over
        Time.timeScale = 0; //quando aparaecer o gamer over o passrinho para
    }
    public void RestartButton()
    {
         SceneManager.LoadScene(0); //para carregar a cena
    }
    public void Scoring()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
