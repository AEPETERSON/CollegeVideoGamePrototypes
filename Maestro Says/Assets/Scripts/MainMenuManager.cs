using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayButton(string startGame)
    {
        SceneManager.LoadScene(startGame); // Loads Maestro Says Game     
    }
    public void ExitButton()
    {
        Application.Quit(); //Quits Maestro Says Game
    }
}
