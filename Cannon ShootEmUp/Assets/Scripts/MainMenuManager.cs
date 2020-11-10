using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Name: Alex Peterson
//Date: April 5, 2019
public class MainMenuManager : MonoBehaviour
{
    
    public void PlayButton(string startGame)
    {
        SceneManager.LoadScene(startGame); //starts game at first level
    }

    public void QuitButton()
    {
        Application.Quit(); //Quits the game
    }
}
