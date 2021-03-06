using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    

    public void Setup(){
        gameObject.SetActive(true);
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu(){
        SceneManager.LoadScene("LevelSelect");
    }

    public void NextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LevelSelect(){
        SceneManager.LoadScene("LevelSelect");
    }
}   
