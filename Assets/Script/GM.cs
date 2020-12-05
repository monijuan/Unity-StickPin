using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    private bool isGameOver = false;

    public Spawner spawner;
    public Rotator rotator;

    public void Start() { }
    public void GameOver()
    {
        if(!isGameOver)
        {
            isGameOver = true;
            Debug.Log("Game Over");
            spawner.enabled = false;
            rotator.enabled = false;
            GetComponent<Animator>().SetTrigger("GameOver");
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
