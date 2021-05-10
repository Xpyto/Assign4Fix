using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuBehavior : MonoBehaviour
{
    public void LevelSelect(){
        SceneManager.LoadScene("LevelSelect");
    }

    public void LoadTutorial(){
        SceneManager.LoadScene("Tutorial");
    }

    public void Loadlvl1(){
        SceneManager.LoadScene("Level1");
    }

    public void Loadlvl2(){
        SceneManager.LoadScene("Level2");
    }

    public void Loadlvl3(){
        SceneManager.LoadScene("Level3");
    }
}

