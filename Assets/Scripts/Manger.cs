using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Manger : MonoBehaviour
{
    GameObject ToChtoIgraet;
    GameObject Blya;

    public GameObject ActTwo;
    public GameObject ActThree;
    public GameObject Titrihi;

    void Start()
    {
        string lname = SceneManager.GetActiveScene().name;
        if (lname == "Vibor")
        {
            if (DontDestroy.actII == true) ActTwo.active = true;
            if (DontDestroy.actIII == true) ActThree.active = true;
            if (DontDestroy.Titri == true) Titrihi.active = true;
        }
    }

    public void Story()
    {
        //gameObject.GetComponent<Sound>().RandomSong();
        Timer.provDen = 1;//1
        Timer.Den = 1;
        SceneManager.LoadScene("Story_Mode");
    }

    public void Akt2()
    {

        Timer.provDen = 4;//4;
        DontDestroy.Mon = DontDestroy.MonAct[0];
        //DontDestroy.Lek = DontDestroy.LekAct[0];
        //DontDestroy.Zav = DontDestroy.ZavAct[0];

        SceneManager.LoadScene("Story_Mode");
    }

    public void Akt3()
    {
        DontDestroy.Mon = DontDestroy.MonAct[1];
        DontDestroy.Lek = DontDestroy.LekAct[1];
        DontDestroy.Zav = DontDestroy.ZavAct[1];

        Timer.provDen = 11;//11
        SceneManager.LoadScene("Story_Mode");
    }

    public void Endless()
    {
        Move.skokrazoshibsa = 0;
        //gameObject.GetComponent<Sound>().RandomSong();
        SceneManager.LoadScene("Endless_Mode");
    }

    public void Menu()
    {
        Blya = GameObject.Find("MuzForPause");
        Blya.GetComponent<AudioSource>().enabled = false;
        ToChtoIgraet = GameObject.Find("DontDestroy(Clone)");
        ToChtoIgraet.GetComponent<AudioSource>().volume = 0.25f;

        Timer.last = 0;
        Timer.cho = 0;
        Move.aga = 0;
        DontDestroy.zapaud1 = 0;
        DontDestroy.Lek = 0;
        DontDestroy.Mon = 0;
        DontDestroy.Zav = 0;
        gameObject.GetComponent<Sound>().MenuSong();
        SceneManager.LoadScene("Menu");
    }

    public void MenuDa()
    {
        SceneManager.LoadScene("Menu");
    }

    public void MenuDaTitri()
    {
        gameObject.GetComponent<Sound>().MenuSong();
        SceneManager.LoadScene("Menu");
    }

    public void ViborAkta()
    {
        Move.skokrazoshibsa = 0;
        SceneManager.LoadScene("Vibor");
    }

    public void TitrScene()
    {
        DontDestroy.zapaud1 = 4;
        gameObject.GetComponent<Sound>().TitriSong();
        SceneManager.LoadScene("Titri");
    }

    public void KonecScene()
    {
        DontDestroy.zapaud1 = 5;
        gameObject.GetComponent<Sound>().KonecSong();
        SceneManager.LoadScene("Koncovki");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
