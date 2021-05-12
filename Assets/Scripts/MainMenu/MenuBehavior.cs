using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuBehavior : MonoBehaviour
{
    public void LevelSelect()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void GotoLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void GotoLevel2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void GotoLevel3()
    {
        SceneManager.LoadScene("Level3");
    }
}
        

