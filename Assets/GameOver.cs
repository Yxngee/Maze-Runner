using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
    

public class GameOver : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("Level1");
    } 
    public void Restart1()
    {
        SceneManager.LoadScene("Level2");
    }  
    public void Next()
    {
        SceneManager.LoadScene("Level2");
    } 
    
    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
    }




}
