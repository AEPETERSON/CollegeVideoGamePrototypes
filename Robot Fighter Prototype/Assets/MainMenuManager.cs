using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Name: Alex Peterson
//February 11, 2019
public class MainMenuManager : MonoBehaviour
{
    public void PlayGame(string newGameLevel)
   {
        SceneManager.LoadScene(newGameLevel); // Loads battle arena demo level       
   }
    public void QuitGameBtn()
    {
        Application.Quit(); //Quits the game
    }
    
}
