using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Timer : MonoBehaviour
{
    public SpriteRenderer _sprite = null;
    public float Speed = 1f;
    public static float timer = 60;
    public Animator contentPanel;
    public Animator TextPanel;
    public Animator ScorePanel;
    public Animator PanelStat;
    public Animator PanelQuest;
    public Animator PanelQuestions;
    public Animator SmertPanel;
    public Animator WhatQPanel;
    private DateTime timerEnd;
    public static int cho = 0;
    public static int last = 0;
    Text TimeToLast;
    public Text DayQuest;
    public Text YHD;
    public Text Denek;
    public Text Denek2;
    public Text DayQuest2;
    int kogo = 0;
    public static TimeSpan delta;

    public Toggle Med;
    public Toggle Dru;
    public Toggle Otl;
    public Slider hp;
    public Slider zv;
   
    // для релога дня
    public static double MonBiff = 0;
    public static double LekBiff = 0;
    public static float ZavBiff = 0;
    public static Slider hpbiff;
    public static Slider zvbiff;
    // для релога дня

    public GameObject knopka;
    public GameObject knopkaPause;

    public GameObject zad1;
    public GameObject zad2;
    public GameObject zad3;
    int zadinkochered = 1;

    public static double Lekabuff = 0;
    public static float zavotdeneg;
    public static float zavotdeneg1;
    public static float zavotdeneg2;

    public static float hpbuf;
    public static float zvbuf;

    int provM = 0;
    int provD = 0;
    int provO = 0;
    double lekbuff;
    float zavbuff;

    public static int provDen = 1;
    public static int Den = 1;
    int provDenek = 0;
    int provDenek2 = 0;

    int zapomnil = 100;
    int zapomnil2 = 100;

    bool proWQ = false;

    public float volume;
    public AudioMixer audiomixer;

    public Sprite[] sprites = new Sprite[2];
    public GameObject MusP;

    bool WhMus = true;

    private void Start()
    {
        DontDestroy.Mon = 0;
        DontDestroy.Lek = 0;

        timerEnd = DateTime.Now.AddSeconds(timer);
        TimeToLast = GetComponent<Text>();

        if (gameObject.tag == "Medicine") Med = GetComponent<Toggle>();
        if (gameObject.tag == "Drug") Dru = GetComponent<Toggle>();

        //provDen = true;

        cho = 10;
        var color = _sprite.color;
        color.a = 1.0f;
        _sprite.color = color;
        Denek.text = "День тура: " + Den + "                              Сегодняшнее задание:";
        Denek2.text = "День тура: " + Den + "                              Сегодняшнее задание:";
        PanePlay();
        ////////////////////////////////////////////////
        string lname = SceneManager.GetActiveScene().name;
        if (lname == "Endless_Mode")
        {
            PanelQu();
            DontDestroy.Zav = 1;
        }
        if (lname == "Story_Mode")
        {
            gameObject.GetComponent<Story>().DayS();
        }
        ////////////////////////////////////////////////
        if (lname == "Endless_Mode")  Quest();
    }

    private void FixedUpdate()
    {
        Denek.text = "День тура: " + Den + "                              Сегодняшнее задание:";
        Denek2.text = "День тура: " + Den + "                              Сегодняшнее задание:";

        zavotdeneg1 = hp.value;
        zavotdeneg2 = zv.value;
        if (cho == 0)
        {
            delta = timerEnd - DateTime.Now;
            Debug.Log(delta.Minutes.ToString("00") + ":" + delta.Seconds.ToString("00"));
            if (delta.TotalSeconds <= 0)
            {
                Debug.Log("The END");
                cho = 1;
            }
            gameObject.GetComponent<Sound>().SoundOn();
        }
        if (cho == 1 && last == 0)
        {
            var color = _sprite.color;
            color.a += Speed * Time.deltaTime;
            color.a = Mathf.Clamp(color.a, 0, 1);
            _sprite.color = color;
            if (color.a == 1) cho = 2;

            provM = 0;
            provD = 0;
        }
        if (cho == 2)
        {
            cho = 3;

            if (kogo == 0)
            {
                kogo = 1;
                PanePlay();
                PanelO();
                NextDay();
                //Quest();
                Vikl();
                gameObject.GetComponent<Sound>().SoundOff();
                if (proWQ == true) WhQuF();
            }
        }
        if (cho == 4)
        {
            var color = _sprite.color;
            if (color.a > 0) color.a -= 0.05f;
            _sprite.color = color;
            if (color.a <= 0) cho = 5;
        }
        if (cho == 5)
        {
            //Debug.Log("TI LOH");
            var color = _sprite.color;
            color.a = 0.0f;
            _sprite.color = color;
            timerEnd = DateTime.Now.AddSeconds(timer);
            cho = 0;
            kogo = 0;
            DengiVKonce.skok = 0;
            DengiVKonce.skokDa = 0;
            Lekabuff = 0;
        }
        if (Move.skokrazoshibsa == 4)
        {
            if (proWQ == true) WhQuF();
            knopka.active = false;
            cho = 10;
            var color = _sprite.color;
            color.a += Speed * Time.deltaTime;
            color.a = Mathf.Clamp(color.a, 0, 1);
            _sprite.color = color;
        }
    }

    public void TransKill()//плохая концовка из-за пропуска транса
    {
        PanePlay();
        Vikl();
        YHD.text = "Из-за вашего неверного выбора бся группа была убита.";
        Animator Deb = SmertPanel;
        Deb.enabled = true;
        bool ijHidden = Deb.GetBool("isHidden");
        Deb.SetBool("isHidden", !ijHidden);
        StartCoroutine(SOS());
    }

    IEnumerator SOS()
    {
        var color = _sprite.color;
        color.a = 0.1f;
        _sprite.color = color;
        yield return new WaitForSeconds(0.1f);
        color.a = 0.2f;
        _sprite.color = color;
        yield return new WaitForSeconds(0.1f);
        color.a = 0.3f;
        _sprite.color = color;
        yield return new WaitForSeconds(0.1f);
        color.a = 0.4f;
        _sprite.color = color;
        yield return new WaitForSeconds(0.1f);
        color.a = 0.5f;
        _sprite.color = color;
        yield return new WaitForSeconds(0.1f);
        color.a = 0.6f;
        _sprite.color = color;
        yield return new WaitForSeconds(0.1f);
        color.a = 0.7f;
        _sprite.color = color;
        yield return new WaitForSeconds(0.1f);
        color.a = 0.8f;
        _sprite.color = color;
        yield return new WaitForSeconds(0.1f);
        color.a = 0.9f;
        _sprite.color = color;
        yield return new WaitForSeconds(0.1f);
        color.a = 1;
        _sprite.color = color;
    }

    public void PanePlay()
    {
        contentPanel.enabled = true;
        bool isHidden = contentPanel.GetBool("isHidden");
        contentPanel.SetBool("isHidden", !isHidden);

        TextPanel.enabled = true;
        bool izHidden = TextPanel.GetBool("isHidden");
        TextPanel.SetBool("isHidden", !izHidden);
    }

    public void PanelO()
    {
        ScorePanel.enabled = true;
        bool ijHidden = ScorePanel.GetBool("isHidden");
        ScorePanel.SetBool("isHidden", !ijHidden);
    }

    public void PanelSt()
    {
        if (zv.value >= 85)
        {
            YHD.text = "Вы умерли от передозировки";
            SmertPanel.enabled = true;
            bool izHidden = SmertPanel.GetBool("isHidden");
            SmertPanel.SetBool("isHidden", !izHidden);
        }
        else
        {
            if (hp.value > 2)
            {
                PanelStat.enabled = true;
                bool isHidden = PanelStat.GetBool("isHidden");
                PanelStat.SetBool("isHidden", !isHidden);
            }
            else
            {
                YHD.text = "Вы умерли от сильной ломки";
                SmertPanel.enabled = true;
                bool ihHidden = SmertPanel.GetBool("isHidden");
                SmertPanel.SetBool("isHidden", !ihHidden);
            }
        }
    }

    public void PanelQu()
    {
        if (DontDestroy.Lek + Lekabuff >= 1000)
        {
            YHD.text = "Вы излечились от зависимости, поздравляю!";
            SmertPanel.enabled = true;
            bool izHidden = SmertPanel.GetBool("isHidden");
            SmertPanel.SetBool("isHidden", !izHidden);
        }
        else
        {
            PanelQuest.enabled = true;
            bool isHidden = PanelQuest.GetBool("isHidden");
            PanelQuest.SetBool("isHidden", !isHidden);
            Move.skokrazoshibsa2 = 0;
        }
    }

    public void Oga()
    {
        cho = 4;
    }

    void NextDay()
    {
        Zadnik();
        SmenaMus();
        string lname = SceneManager.GetActiveScene().name;
        if (lname == "Endless_Mode")  Move.skokrazoshibsa = 0;
        //Quest();
        //Move.zadanie1 = 0;
        //Move.zadanie2 = 0;
        //Move.zadanie3 = 0;
        //lekbuff = DontDestroy.Lek;
        lekbuff = Lekabuff;
        zv.value += DontDestroy.Zav * 2.5f;
        //hp.value = hp.value / ((zv.value + 100.0f)/100.0f);
        hp.value = hp.value / (1.0f + (zv.value / 100.0f));
        hpbuf = hp.value;
        zvbuf = zv.value;

        Den += 1;
        provDen += 1;
        //Denek.text = "День тура: " + Den + "                              Сегодняшнее задание:";
        //Denek2.text = "День тура: " + Den + "                              Сегодняшнее задание:";

        if (provDenek == 1)
        {
            ViborM();
            Med.GetComponent<Toggle>().isOn = false;
        }
        if (provDenek == 2)
        {
            ViborD();
            Dru.GetComponent<Toggle>().isOn = false;
        }
        if (provDenek2 == 1)
        {
            //ViborO();
            Otl.GetComponent<Toggle>().isOn = false;
        }

        provM = 0;
        provD = 0;
        provO = 0;
        provDenek = 0;
        provDenek2 = 0;
        hp.value = hpbuf;
        zv.value = zvbuf;
    }

    public void ViborM()
    {
        hp.value = hpbuf;
        zv.value = zvbuf;
        if (provM == 0)
        {
            provM = 1;
        }
        if (provM == 2)
        {
            hp.value = hpbuf;
            zv.value = zvbuf;
            provM = 0;
            DontDestroy.Mon += 10;
            DontDestroy.Zav = zavbuff;
        }
        if (provM == 1 && DontDestroy.Mon >= 10)
        {
            hp.value -= 5.0f;
            zv.value -= 15.0f;
            provM = 2;
            DontDestroy.Mon -= 10;
            DontDestroy.Zav = 1;
        }
        else Med.GetComponent<Toggle>().isOn = false;
        provDenek = 1;
    }

    public void ViborD()
    {
        hp.value = hpbuf;
        zv.value = zvbuf;
        if (provD == 0)
        {
            provD = 1;
        }
        if (provD == 2)
        {
            hp.value = hpbuf;
            zv.value = zvbuf;
            provD = 0;
            DontDestroy.Mon += 10;
            DontDestroy.Zav -= 1;
        }
        if (provD == 1 && DontDestroy.Mon >= 10)
        {
            if (hp.value < 100.0f) hp.value += 15.0f;
            if (zv.value < 100.0f) zv.value += 5.0f;
            provD = 2;
            DontDestroy.Mon -= 10;
            DontDestroy.Zav += 1;
        }
        else Dru.GetComponent<Toggle>().isOn = false;
        provDenek = 2;
    }

    public void ViborO()//отложить на лекарство
    {
        if (provO == 0)
        {
            provO = 1;
        }
        if (provO == 2)
        {
            DontDestroy.Mon += Lekabuff - lekbuff;
            Lekabuff = lekbuff;
            provO = 0;
        }
        if (provO == 1 && DontDestroy.Mon > 0)
        {
            Lekabuff += DontDestroy.Mon;
            DontDestroy.Mon = 0;
            provO = 2;
        }
        else Otl.GetComponent<Toggle>().isOn = false;
        provDenek2 = 1;
    }

    public void Quest()
    {
        int otvet;
        string[] strArr = new string[4] { "Пускать только блондинок.", "Пускать только брюнеток.", "Пускать рыжих девушек.", "Пускать всех красивых девушек" };
        otvet = UnityEngine.Random.Range(0, 4);
        if (otvet != zapomnil && otvet != zapomnil2)
        {
            zapomnil2 = zapomnil;
            zapomnil = otvet;
            DayQuest.text = strArr[otvet];
            DayQuest2.text = strArr[otvet];
            Move.zadanie1 = otvet + 1; //тип девушки
            int otvet2;
            otvet2 = UnityEngine.Random.Range(0, 2);
            if (otvet2 == 1) Quest2();
            else
            {
                Move.zadanie2 = 0;
                Move.zadanie3 = 0;
            }
        }
        else Quest();
    }

    void Quest2()
    {
        int otvet;
        string[] strArr = new string[4] { "Пускать только тру-фанаток.", "Пускать только девушек со стаффом: ", "Пускать девушек с возрастом меньше ", "Пускать девушек с возрастом больше " };
        otvet = UnityEngine.Random.Range(0, 4);
        DayQuest.text += "                                        " + strArr[otvet];
        DayQuest2.text += "                                        " + strArr[otvet];
        if (otvet == 0) Move.zadanie2 = 1; // тру фанатка
        if (otvet == 1)
        {
            int otvet2;
            otvet2 = UnityEngine.Random.Range(0, 4);
            if (otvet2 == 0) Move.zadanie2 = 20; // "LCD-TV"  
            if (otvet2 == 1) Move.zadanie2 = 21; // "PlanB"
            if (otvet2 == 2) Move.zadanie2 = 22; // "Kokos"
            if (otvet2 == 3) Move.zadanie2 = 23; // любой
            if (otvet2 != 3)
            {
                DayQuest.text += ModelsBio.ves[otvet2];
                DayQuest2.text += ModelsBio.ves[otvet2];
            }
            else
            {
                DayQuest.text += "любым";
                DayQuest2.text += "любым";
            }
        }
        if (otvet == 2)
        {
            int otvet2;
            otvet2 = UnityEngine.Random.Range(22, 29);
            Move.zadanie2 = 31;
            Move.zadanie3 = otvet2; //возраст меньше которого нужно брать
            DayQuest.text += otvet2;
            DayQuest2.text += otvet2;
        }
        if (otvet == 3)
        {
            int otvet2;
            otvet2 = UnityEngine.Random.Range(18, 25);
            Move.zadanie2 = 32;
            Move.zadanie3 = otvet2; //возраст больше которого нужно брать
            DayQuest.text += otvet2;
            DayQuest2.text += otvet2;
        }
    }

    public void MonCash()
    {
        DontDestroy.Lek += Lekabuff;
    }

    public void Podschet()
    {
        zavbuff = DontDestroy.Zav;
        StartCoroutine(SIS());
    }

    IEnumerator SIS()
    {
        yield return new WaitForSeconds(1.0f);
        zavotdeneg = 100 - hp.value;
        DontDestroy.Mon -= zavotdeneg + 10;
    }

    public void DopP()
    {
        if (Move.aga == 1)
        {
            contentPanel.enabled = true;
            bool isHidden = contentPanel.GetBool("isHidden");
            contentPanel.SetBool("isHidden", !isHidden);

            PanelQuestions.enabled = true;
            bool izHidden = PanelQuestions.GetBool("isHidden");
            PanelQuestions.SetBool("isHidden", !izHidden);
        }
    }

    public void WhQu()
    {
        proWQ = true;
        WhatQPanel.enabled = true;
        bool izHidden = WhatQPanel.GetBool("isHidden");
        WhatQPanel.SetBool("isHidden", !izHidden);

    }

    public void WhQuF()
    {
        proWQ = false;
        WhatQPanel.enabled = true;
        bool izHidden = WhatQPanel.GetBool("isHidden");
        WhatQPanel.SetBool("isHidden", !izHidden);

    }

    public void Vkl()
    {
        knopka.active = true;
        //knopkaPause.active = true;
        //if (Den != 1) gameObject.GetComponent<Sound>().RandomSong();
    }

    public void Vikl()
    {
        knopka.active = false;
        //knopkaPause.active = false;
    }

    void Zadnik()
    {
        if (zadinkochered <= 3) zadinkochered += 1;
        else zadinkochered = 1;
        if (zadinkochered == 1)
        {
            Vector3 pos1 = zad3.transform.position;
            Vector3 pos2 = zad1.transform.position;

            zad1.transform.position = pos1;
            zad3.transform.position = pos2;
        }
        if (zadinkochered == 2)
        {
            Vector3 pos1 = zad1.transform.position;
            Vector3 pos2 = zad2.transform.position;

            zad2.transform.position = pos1;
            zad1.transform.position = pos2;
        }
        if (zadinkochered == 3)
        {
            Vector3 pos1 = zad2.transform.position;
            Vector3 pos2 = zad3.transform.position;

            zad3.transform.position = pos1;
            zad2.transform.position = pos2;
        }
        if (zadinkochered > 3) Zadnik();
    }

    int pauseorplay = 0;
    DateTime deltabuff;

    public void Pause()
    {
        //if (pauseorplay == 0)
        //{
        //    deltabuff = timerEnd;
        //    Time.timeScale = 0;
        //    pauseorplay = 1;
        //    return;
        //}
        //if (pauseorplay == 1)
        //{
        //    timerEnd = deltabuff;
        //    Time.timeScale = 1;
        //    pauseorplay = 0;
        //    return;
        //}
    }

    int provaudio = 0;

    public void Sound()
    {
        if (AudioListener.volume == 1)
        {
            AudioListener.volume = 0;
            provaudio = 1;
        }
        else
        {
            AudioListener.volume = 1;
            provaudio = 0;
        }
    }

    void SmenaMus()
    {
        if (WhMus == false)
        {
            WhMus = true;
            MusP.GetComponent<Image>().sprite = sprites[0];
            return;
        }
        if (WhMus == true)
        {
            WhMus = false;
            MusP.GetComponent<Image>().sprite = sprites[1];
            return;
        }
    }

}
