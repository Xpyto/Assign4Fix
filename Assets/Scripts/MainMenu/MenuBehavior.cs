using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuBehavior : MonoBehaviour
{
    public void LevelSelect(){
        SceneManager.LoadScene("Tutorial");
    }
}
