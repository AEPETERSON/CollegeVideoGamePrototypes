using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayButton(string startLevel1)
    {
        SceneManager.LoadScene(startLevel1); // Loads Level 1 Scene      
    }
    public void ExitButton()
    {
        Application.Quit(); //Quits the game
    }



    // Update is called once per frame
}
