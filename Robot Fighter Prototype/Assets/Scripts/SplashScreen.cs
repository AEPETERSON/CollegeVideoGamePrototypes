using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Name: Alex Peterson
//Date: February 11, 2019
public class SplashScreen : MonoBehaviour
{
    public static int sceneNum;
    public Texture2D _splashScreenBackGround;   //creates slot in inspector to assign splash screen background image
                                                //creates slot in inspecter to  assign splash screen text

    private AudioSource _splashScreenAudio;    //defines naming convention for audio source component
    public AudioClip _splashScreenMusic;       //create slot in inspector to assign splash screen music
    //private float _splashScreenFadeValue;      //defines fade value
    //private float _splashScreenFadeSpeed = 0.15f;    //defines fade speed
    //private SplashScreenController _splashScreenController;
    private enum SplashScreenController         //defines states for splash screen
    {
        SplashScreenFadeIn = 0,
        SplashScreenFadeOut = 1
    }
    //void Awake()
    //{
    //    _splashScreenFadeValue = 0;     //Fade value will equal zero on start up screen

    //}

    // Start is called before the first frame update
    void Start()
    {

        //    Cursor.visible = false;         //set the cursor visible state to false
        //    Cursor.lockState = CursorLockMode.Locked;   //locks the cursor
        //    _splashScreenAudio = GetComponent<AudioSource>();    //splashscreen audio equals the audio source
        //    _splashScreenAudio.volume = 0;          //Audio volume equals zero on start up
        //    _splashScreenAudio.clip = _splashScreenMusic;       //Audio clip equals splash screen music
        //    _splashScreenAudio.loop = true;         //set audio to loop
        //    _splashScreenAudio.Play();          //plays audio
        //    _splashScreenController = SplashScreen.SplashScreenController.SplashScreenFadeIn;
        if (sceneNum == 0)
        {
            StartCoroutine(ToMainMenu());       //takes you to main menu
        }
    }
        //State equals fade in on start up screen
        //StartCoroutine("SplashScreenManager");             //Start SplashScreenManager Function
        //}

        // Update is called once per frame
    void Update()
    {
        
               
    }
    //private IEnumerator SplashScreenManager()
    //{
    //    while (true)
    //    {
    //        switch (_splashScreenController)
    //        { 
    //            case SplashScreenController.SplashScreenFadeIn:
    //                SplashScreenFadeIn();
    //                break;
    //            case SplashScreenController.SplashScreenFadeOut:
    //                SplashScreenFadeOut();
    //                break;
    //        }
    //        yield return null;
    //    }
    //}

    IEnumerator ToMainMenu()
    {
        yield return new WaitForSeconds(2);
        sceneNum = 1;
        SceneManager.LoadScene(1);
    }

    //private void SplashScreenFadeIn()
    //{
    //    Debug.Log("SplashScreenFadeIn");
    //    _splashScreenAudio.volume += _splashScreenFadeSpeed * Time.deltaTime;   //increase volume by fade value
    //    _splashScreenFadeValue += _splashScreenFadeSpeed * Time.deltaTime;      //increase fade value by fade speed
    //    if(_splashScreenFadeValue > 1)
    //    {
    //        _splashScreenFadeValue = 1;     //If fade value is greater than one then set value to one
    //    }
    //    if(_splashScreenFadeValue == 1)     //if fade value equals 1
    //    {
    //        _splashScreenController = SplashScreen.SplashScreenController.SplashScreenFadeOut;  //set splashscreen controller to splash screen fade out            
    //    }
    //}

    //private void SplashScreenFadeOut()
    //{
    //    Debug.Log("SplashScreenFadeOut");
    //    _splashScreenAudio.volume -= _splashScreenFadeSpeed * Time.deltaTime;   //decrease volume by fade value
    //    _splashScreenFadeValue -= _splashScreenFadeSpeed * Time.deltaTime;      //decrease fade value by fade speed
    //    if (_splashScreenFadeValue < 0)
    //    {
    //        _splashScreenFadeValue = 0;     //If fade value is less than zero then set value to zero
    //    }
    //    if (_splashScreenFadeValue == 0)     //if fade value equals 0
    //    {
    //        SceneManager.LoadScene("ControllerWarning");         //Load scene ControllerWarning which warns the player that this game is for a controller only (no mouse and keyboard)          
    //    }
    //}

    //private void OnGUI()
    //{
    //    GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), _splashScreenBackGround);      //Draw a texture starting at point (0,0)
    //                                                                                                //By screen width and screen height
    //    GUI.color = new Color(1, 1, 1, _splashScreenFadeValue);                                        //GUI color equal to (1,1,1) plus the fade value                                                                                           //Drawing background texture

    //    GUIText.            //Draw a texture starting at point 
    //By screen width and screen height
    //Drawing background text
    //}

}
