using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Name: Alex Peterson
//Date: May 6, 2019
public class PlayerInput : MonoBehaviour
{
    public Animator PlayerButtonInput1;
    public Animator PlayerButtonInput2;
    public Animator PlayerButtonInput3;
    public Animator PlayerButtonInput4;
    public Animator PlayerButtonInput5;
    public Animator PlayerButtonInput6;
    public Animator PlayerButtonInput7;
    public Animator PlayerButtonInput8;
    public Animator PlayerButtonInput9;
    public Animator PlayerButtonInput10;
    public Animator PlayerButtonInput11;
    public Animator PlayerButtonInput12;
    AudioSource ButtonSound;
    //public AudioSource PlayerButtonSound1;
    //public AudioSource PlayerButtonSound2;
    //public AudioSource PlayerButtonSound3;
    //public AudioSource PlayerButtonSound4;
    //public AudioSource PlayerButtonSound5;
    //public AudioSource PlayerButtonSound6;
    //public AudioSource PlayerButtonSound7;
    //public AudioSource PlayerButtonSound8;
    //public AudioSource PlayerButtonSound9;
    //public AudioSource PlayerButtonSound10;
    //public AudioSource PlayerButtonSound11;
    //public AudioSource PlayerButtonSound12;
    // Start is called before the first frame update
    void Start()
    {
        ButtonSound = this.GetComponent<AudioSource>();
        ButtonSound.Stop();
        PlayerButtonInput1 = GetComponent<Animator>();
        PlayerButtonInput2 = GetComponent<Animator>();
        PlayerButtonInput3 = GetComponent<Animator>();
        PlayerButtonInput4 = GetComponent<Animator>();
        PlayerButtonInput5 = GetComponent<Animator>();
        PlayerButtonInput6 = GetComponent<Animator>();
        PlayerButtonInput7 = GetComponent<Animator>();
        PlayerButtonInput8 = GetComponent<Animator>();
        PlayerButtonInput9 = GetComponent<Animator>();
        PlayerButtonInput10 = GetComponent<Animator>();
        PlayerButtonInput11 = GetComponent<Animator>();
        PlayerButtonInput12 = GetComponent<Animator>();
        
        //PlayerButtonSound1 = GetComponent<AudioSource>();
        //PlayerButtonSound2 = GetComponent<AudioSource>();
        //PlayerButtonSound3 = GetComponent<AudioSource>();
        //PlayerButtonSound4 = GetComponent<AudioSource>();
        //PlayerButtonSound5 = GetComponent<AudioSource>();
        //PlayerButtonSound6 = GetComponent<AudioSource>();
        //PlayerButtonSound7 = GetComponent<AudioSource>();
        //PlayerButtonSound8 = GetComponent<AudioSource>();
        //PlayerButtonSound9 = GetComponent<AudioSource>();
        //PlayerButtonSound10 = GetComponent<AudioSource>();
        //PlayerButtonSound11 = GetComponent<AudioSource>();
        //PlayerButtonSound12 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {

                if (hit.transform.name == this.transform.name)
                {
                    PlayerButtonInput1.Play("Button1on");
                    ButtonSound.Play();
                    Debug.Log(hit.transform.name);
                }
                if (hit.transform.name == this.transform.name)
                {
                    PlayerButtonInput2.Play("Button2on");
                    ButtonSound.Play();
                    Debug.Log(hit.transform.name);
                }
                if (hit.transform.name == this.transform.name)
                {
                    PlayerButtonInput3.Play("Button3on");
                    ButtonSound.Play();
                    Debug.Log(hit.transform.name);
                }
                if (hit.transform.name == this.transform.name)
                {
                    PlayerButtonInput4.Play("Button4on");
                    ButtonSound.Play();
                    Debug.Log(hit.transform.name);
                }
                if (hit.transform.name == this.transform.name)
                {
                    PlayerButtonInput5.Play("Button5on");
                    ButtonSound.Play();
                    Debug.Log(hit.transform.name);
                }
                if (hit.transform.name == this.transform.name)
                {
                    PlayerButtonInput6.Play("Button6on");
                    ButtonSound.Play();
                    Debug.Log(hit.transform.name);
                }
                if (hit.transform.name == this.transform.name)
                {
                    PlayerButtonInput7.Play("Button7on");
                    ButtonSound.Play();
                    Debug.Log(hit.transform.name);
                }
                if (hit.transform.name == this.transform.name)
                {
                    PlayerButtonInput8.Play("Button8on");
                    ButtonSound.Play();
                    Debug.Log(hit.transform.name);
                }
                if (hit.transform.name == this.transform.name)
                {
                    PlayerButtonInput9.Play("Button9on");
                    ButtonSound.Play();
                    Debug.Log(hit.transform.name);
                }
                if (hit.transform.name == this.transform.name)
                {
                    PlayerButtonInput10.Play("Button10on");
                    ButtonSound.Play();
                    Debug.Log(hit.transform.name);
                }
                if (hit.transform.name == this.transform.name)
                {
                    PlayerButtonInput11.Play("Button11on");
                    ButtonSound.Play();
                    Debug.Log(hit.transform.name);
                }
                if (hit.transform.name == this.transform.name)
                {
                    PlayerButtonInput12.Play("Button12on");
                    ButtonSound.Play();
                    Debug.Log(hit.transform.name);
                }
            }

            
            

        }
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Buttonoff1")
                {
                    PlayerButtonInput1.Play("Button1off");
                    //PlayerButtonSound1.Stop();
                }
                if (hit.transform.name == "Buttonoff2")
                {
                    PlayerButtonInput2.Play("Button2off");
                    //PlayerButtonSound2.Stop();

                }
                if (hit.transform.name == "Buttonoff3")
                {
                    PlayerButtonInput3.Play("Button3off");
                    //PlayerButtonSound3.Stop();
                }
                if (hit.transform.name == "Buttonoff4")
                {
                    PlayerButtonInput4.Play("Button4off");
                    //PlayerButtonSound4.Stop();
                }
                if (hit.transform.name == "Buttonoff5")
                {
                    PlayerButtonInput5.Play("Button5off");
                    //PlayerButtonSound5.Stop();
                }
                if (hit.transform.name == "Buttonoff6")
                {
                    PlayerButtonInput6.Play("Button6off");
                    //PlayerButtonSound6.Stop();
                }
                if (hit.transform.name == "Buttonoff7")
                {
                    PlayerButtonInput7.Play("Button7off");
                }
                if (hit.transform.name == "Buttonoff8")
                {
                    PlayerButtonInput8.Play("Button8off");
                }
                if (hit.transform.name == "Buttonoff9")
                {
                    PlayerButtonInput9.Play("Button9off");
                }
                if (hit.transform.name == "Buttonoff10")
                {
                    PlayerButtonInput10.Play("Button10off");
                }
                if (hit.transform.name == "Buttonoff11")
                {
                    PlayerButtonInput11.Play("Button11off");
                }
                if (hit.transform.name == "Buttonoff12")
                {
                    PlayerButtonInput12.Play("Button12off");
                }
                

            }
            


            
        }

    }
}