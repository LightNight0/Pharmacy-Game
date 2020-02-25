using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Move : MonoBehaviour
{

    //public Animator contentPanel;
    public Animator DialogPanel;

    public static int aga = 0;
    int ag1 = 0;
    GameObject model;
    GameObject spa;
    GameObject contrl;

    public Animator TimePanel1;
    public Animator PanelPlay1;

    public Animator Oshibka;
    public Text OshibkaText;

    public Animator YD;
    public Text YDText;

    public static int zadanie1 = 0;
    public static int zadanie2 = 0;
    public static int zadanie3 = 0;

    public static int podhodit1 = 0;
    public static int podhodit2 = 0;
    public static int podhodit3 = 0;

    public static int skokrazoshibsa = 0;
    public static int skokrazoshibsa2 = 0;

    GameObject pers;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (ag1 == 1)
        {
            model.transform.position = model.transform.position + new Vector3(0.15f, 0);
            if (model.transform.position.x > 0)
            {
                ag1 = 0;
                aga = 1;

                pers = GameObject.FindWithTag("Model");
                if (pers.name == "Nark(Clone)" && DontDestroy.nark == true) Nark_Help();

                DialogPanel.enabled = true;
                bool isHidden = DialogPanel.GetBool("isHidden");
                DialogPanel.SetBool("isHidden", !isHidden);
            }
        }

        if (ag1 == 2)
        {
            model.transform.position = model.transform.position + new Vector3(0.15f, 0);
            if (model.transform.position.x > 15) ag1 = 0;
        }

        if (ag1 == 3)
        {
            model.transform.position = model.transform.position + new Vector3(-0.15f, 0);
            if (model.transform.position.x < -15) ag1 = 0;
        }
    }

    public void Move_Bitch()
    {
        //ControllRoom.ochered = 1;
        //contentPanel.enabled = true;
        //aga = 1;
        //bool isHidden = contentPanel.GetBool("isHidden");
        //contentPanel.SetBool("isHidden", !isHidden);
        if (aga == 0 && Timer.cho < 1) 
        {
            model = GameObject.FindWithTag("Model");
            Vector2 pos = model.transform.position;
            if (model.transform.position.x < 0) ag1 = 1;
            Timer.last = 1;

            contrl = GameObject.FindWithTag("Control");
            contrl.GetComponent<ModelsBio>().NewM();
        }
    }

    public void Yeas_Bitch()
    {
        if (aga == 1)
        {
            //    contentPanel.enabled = true;
            //    bool GoF = contentPanel.GetBool("GoF");
            //    contentPanel.SetBool("GoF", !GoF);
            //    StartCoroutine(SIS());
            //}
            //model = GameObject.FindWithTag("Model");
            Vector2 pos = model.transform.position;
            ag1 = 2;
            aga = 2;
            StartCoroutine(SIS());

            pers = GameObject.FindWithTag("Model");
            if (pers.name == "Rep(Clone)")
            {
                DontDestroy.report1 = true;
                if (DontDestroy.report1 == true) DontDestroy.report2 = true;
                if (DontDestroy.report1 == false && Timer.provDen == 11) DontDestroy.report2 = true;
            }
            if (pers.name == "Nark(Clone)" && DontDestroy.nark == false)
            {
                DialogPanel.enabled = true;
                bool isHidden = DialogPanel.GetBool("isHidden");
                DialogPanel.SetBool("isHidden", !isHidden);

                DontDestroy.nark = true;
                DontDestroy.Mon -= 250;
                //if (DontDestroy.Mon < 0) DontDestroy.Mon = 0;
                aga = 1;
                No_Bitch();
                return;
            }
            if (pers.name == "TransB(Clone)")
            {
                DontDestroy.trans = true;
                gameObject.GetComponent<Timer>().TransKill();
            }
            if (pers.name == "Ber(Clone)")
            {
                DontDestroy.pregant = true;
            }
            if (pers.name == "BW(Clone)")
            {
                DontDestroy.Mon += 350;
                DontDestroy.busw = true;
            }
            if (pers.name == "TryFan(Clone)")
            {
                DontDestroy.uberfan = true;
            }
            if (pers.name == "Nark(Clone)") return;
            else
            if (ModelsBio.charectirtO2 != 6)
            {
                if (ModelsBio.charectirtO2 != 4)
                {
                    if (ModelsBio.charectirtO3 >= 18)
                    {
                        if (zadanie1 == podhodit1 || zadanie1 == 4)
                        {
                            if (zadanie2 == 0)
                            {
                                DengiVKonce.skok += 1;
                                DontDestroy.Mon += 25;
                            }
                            if (zadanie2 == 1) //проверка на фанатку
                            {
                                if (ModelsBio.charectirtO1 == 1)
                                {
                                    DengiVKonce.skok += 1;
                                    DontDestroy.Mon += 25;
                                }
                                else
                                {
                                    skokrazoshibsa += 1;
                                    skokrazoshibsa2 += 1;
                                    if (skokrazoshibsa < 3) OshibkaText.text = "Ты налажал, она не фанатка!, это " + skokrazoshibsa + " ошибка - штраф: " + skokrazoshibsa * 5 + "$";
                                    if (skokrazoshibsa == 3) OshibkaText.text = "Ты налажал, она не фанатка!, это " + skokrazoshibsa + " ошибка - штраф: " + skokrazoshibsa * 5 + "$, последнее предупреждение!";
                                    if (skokrazoshibsa == 4) OshibkaText.text = "Ты налажал в последний раз, ты уволен!";
                                    DontDestroy.Mon -= skokrazoshibsa * 5;
                                    Oshibsa();
                                }
                            }
                            if (zadanie2 == 20) //проверка на "LCD-TV"  
                            {
                                if (ModelsBio.charectirtO2 == 1)
                                {
                                    DengiVKonce.skok += 1;
                                    DontDestroy.Mon += 25;
                                }
                                else
                                {
                                    skokrazoshibsa += 1;
                                    skokrazoshibsa2 += 1;
                                    if (skokrazoshibsa < 3) OshibkaText.text = "Ты налажал, у неё нет LCD-TV!, это " + skokrazoshibsa + " ошибка - штраф: " + skokrazoshibsa * 5 + "$";
                                    if (skokrazoshibsa == 3) OshibkaText.text = "Ты налажал, у неё нет LCD-TV!, это " + skokrazoshibsa + " ошибка - штраф: " + skokrazoshibsa * 5 + "$, последнее предупреждение!";
                                    if (skokrazoshibsa == 4) OshibkaText.text = "Ты налажал в последний раз, ты уволен!";
                                    DontDestroy.Mon -= skokrazoshibsa * 5;
                                    Oshibsa();
                                }
                            }
                            if (zadanie2 == 21) //проверка на "PlanB"
                            {
                                if (ModelsBio.charectirtO2 == 2)
                                {
                                    DengiVKonce.skok += 1;
                                    DontDestroy.Mon += 25;
                                }
                                else
                                {
                                    skokrazoshibsa += 1;
                                    skokrazoshibsa2 += 1;
                                    if (skokrazoshibsa < 3) OshibkaText.text = "Ты налажал, у неё нет PlanB!, это " + skokrazoshibsa + " ошибка - штраф: " + skokrazoshibsa * 5 + "$";
                                    if (skokrazoshibsa == 3) OshibkaText.text = "Ты налажал, у неё нет PlanB!, это " + skokrazoshibsa + " ошибка - штраф: " + skokrazoshibsa * 5 + "$, последнее предупреждение!";
                                    if (skokrazoshibsa == 4) OshibkaText.text = "Ты налажал в последний раз, ты уволен!";
                                    DontDestroy.Mon -= skokrazoshibsa * 5;
                                    Oshibsa();
                                }
                            }
                            if (zadanie2 == 22) //проверка на "Kokos"
                            {
                                if (ModelsBio.charectirtO2 == 3)
                                {
                                    DengiVKonce.skok += 1;
                                    DontDestroy.Mon += 25;
                                }
                                else
                                {
                                    skokrazoshibsa += 1;
                                    skokrazoshibsa2 += 1;
                                    if (skokrazoshibsa < 3) OshibkaText.text = "Ты налажал, у неё нет Kokos'a!, это " + skokrazoshibsa + " ошибка - штраф: " + skokrazoshibsa * 5 + "$";
                                    if (skokrazoshibsa == 3) OshibkaText.text = "Ты налажал, у неё нет Kokos'a!, это " + skokrazoshibsa + " ошибка - штраф: " + skokrazoshibsa * 5 + "$, последнее предупреждение!";
                                    if (skokrazoshibsa == 4) OshibkaText.text = "Ты налажал в последний раз, ты уволен!";
                                    DontDestroy.Mon -= skokrazoshibsa * 5;
                                    Oshibsa();
                                }
                            }
                            if (zadanie2 == 23) //проверка на любое
                            {
                                if (ModelsBio.charectirtO2 <= 3 && ModelsBio.charectirtO2 > 0)
                                {
                                    DengiVKonce.skok += 1;
                                    DontDestroy.Mon += 25;
                                }
                                else
                                {
                                    skokrazoshibsa += 1;
                                    skokrazoshibsa2 += 1;
                                    if (skokrazoshibsa < 3) OshibkaText.text = "Ты налажал, у неё нет веществ!, это " + skokrazoshibsa + " ошибка - штраф: " + skokrazoshibsa * 5 + "$";
                                    if (skokrazoshibsa == 3) OshibkaText.text = "Ты налажал, у неё нет веществ!, это " + skokrazoshibsa + " ошибка - штраф: " + skokrazoshibsa * 5 + "$, последнее предупреждение!";
                                    if (skokrazoshibsa == 4) OshibkaText.text = "Ты налажал в последний раз, ты уволен!";
                                    DontDestroy.Mon -= skokrazoshibsa * 5;
                                    Oshibsa();
                                }
                            }
                            if (zadanie2 == 31) //проверка на возраст меньше которого нужно брать
                            {
                                if (ModelsBio.charectirtO3 <= zadanie3)
                                {
                                    DengiVKonce.skok += 1;
                                    DontDestroy.Mon += 25;
                                }
                                else
                                {
                                    skokrazoshibsa += 1;
                                    skokrazoshibsa2 += 1;
                                    if (skokrazoshibsa < 3) OshibkaText.text = "Ты налажал, она старше " + zadanie3 + "!, это " + skokrazoshibsa + " ошибка - штраф: " + skokrazoshibsa * 5 + "$";
                                    if (skokrazoshibsa == 3) OshibkaText.text = "Ты налажал, она старше " + zadanie3 + "!, это " + skokrazoshibsa + " ошибка - штраф: " + skokrazoshibsa * 5 + "$, последнее предупреждение!";
                                    if (skokrazoshibsa == 4) OshibkaText.text = "Ты налажал в последний раз, ты уволен!";
                                    DontDestroy.Mon -= skokrazoshibsa * 5;
                                    Oshibsa();
                                }
                            }
                            if (zadanie2 == 32) //проверка на возраст больше которого нужно брать
                            {
                                if (ModelsBio.charectirtO3 >= zadanie3)
                                {
                                    DengiVKonce.skok += 1;
                                    DontDestroy.Mon += 25;
                                }
                                else
                                {
                                    skokrazoshibsa += 1;
                                    skokrazoshibsa2 += 1;
                                    if (skokrazoshibsa < 3) OshibkaText.text = "Ты налажал, она младше " + zadanie3 + "!, это " + skokrazoshibsa + " ошибка - штраф: " + skokrazoshibsa * 5 + "$";
                                    if (skokrazoshibsa == 3) OshibkaText.text = "Ты налажал, она младше " + zadanie3 + "!, это " + skokrazoshibsa + " ошибка - штраф: " + skokrazoshibsa * 5 + "$, последнее предупреждение!";
                                    if (skokrazoshibsa == 4) OshibkaText.text = "Ты налажал в последний раз, ты уволен!";
                                    DontDestroy.Mon -= skokrazoshibsa * 5;
                                    Oshibsa();
                                }
                            }
                        }
                        else
                        {
                            skokrazoshibsa += 1;
                            skokrazoshibsa2 += 1;
                            if (skokrazoshibsa < 3) OshibkaText.text = "Ты налажал, цвет волос не тот!, это " + skokrazoshibsa + " ошибка - штраф: " + skokrazoshibsa * 5 + "$";
                            if (skokrazoshibsa == 3) OshibkaText.text = "Ты налажал, цвет волос не тот!, это " + skokrazoshibsa + " ошибка - штраф: " + skokrazoshibsa * 5 + "$, последнее предупреждение!";
                            if (skokrazoshibsa == 4) OshibkaText.text = "Ты налажал в последний раз, ты уволен!";
                            DontDestroy.Mon -= skokrazoshibsa * 5;
                            Oshibsa();
                        }
                    }
                    else
                    {
                        skokrazoshibsa += 1;
                        skokrazoshibsa2 += 1;
                        if (skokrazoshibsa < 3) OshibkaText.text = "Ты налажал, ей нет 18!, это " + skokrazoshibsa + " ошибка - штраф: " + skokrazoshibsa * 5 + "$";
                        if (skokrazoshibsa == 3) OshibkaText.text = "Ты налажал, ей нет 18!, это " + skokrazoshibsa + " ошибка - штраф: " + skokrazoshibsa * 5 + "$, последнее предупреждение!";
                        if (skokrazoshibsa == 4) OshibkaText.text = "Ты налажал в последний раз, ты уволен!";
                        DontDestroy.Mon -= skokrazoshibsa * 5;
                        Oshibsa();
                    }
                }
                else
                {
                    skokrazoshibsa += 1;
                    skokrazoshibsa2 += 1;
                    if (skokrazoshibsa < 3) OshibkaText.text = "Ты налажал, она тупая папарацци!, это " + skokrazoshibsa + " ошибка - штраф: " + skokrazoshibsa * 5 + "$";
                    if (skokrazoshibsa == 3) OshibkaText.text = "Ты налажал, она тупая папарацци!, это " + skokrazoshibsa + " ошибка - штраф: " + skokrazoshibsa * 5 + "$, последнее предупреждение!";
                    if (skokrazoshibsa == 4) OshibkaText.text = "Ты налажал в последний раз, ты уволен!";
                    DontDestroy.Mon -= skokrazoshibsa * 5;
                    Oshibsa();
                }
            }
            else
            {
                skokrazoshibsa += 1;
                skokrazoshibsa2 += 1;
                if (skokrazoshibsa < 3) OshibkaText.text = "Ты налажал, у нее, ***, у него подвох!, это " + skokrazoshibsa + " ошибка - штраф: " + skokrazoshibsa * 5 + "$";
                if (skokrazoshibsa == 3) OshibkaText.text = "Ты налажал, у нее, ***, у него подвох!, это " + skokrazoshibsa + " ошибка - штраф: " + skokrazoshibsa * 5 + "$, последнее предупреждение!";
                if (skokrazoshibsa == 4) OshibkaText.text = "Ты налажал в последний раз, ты уволен!";
                DontDestroy.Mon -= skokrazoshibsa * 5;
                Oshibsa();
            }
            if (skokrazoshibsa == 4) D();
        }
    }

    public void No_Bitch()
    {
        if (aga == 1)
        {
            pers = GameObject.FindWithTag("Model");
            if (pers.name == "TransB(Clone)")
            {
                gameObject.GetComponent<Timer>().hp.value -= 30;
                if (gameObject.GetComponent<Timer>().hp.value < 15) gameObject.GetComponent<Timer>().hp.value = 10;
            }
            //    contentPanel.enabled = true;
            //    bool GoNo = contentPanel.GetBool("GoNo");
            //    contentPanel.SetBool("GoNo", !GoNo);
            //    StartCoroutine(SIS());
            //}
            //model = GameObject.FindWithTag("Model");
            Vector2 pos = model.transform.position;
            ag1 = 3;
            aga = 3;
            if (pers.name == "Nark(Clone)" && DontDestroy.nark == true) aga = 2;
            StartCoroutine(SIS());
        }
    }

    void Oshibsa()
    {
        Oshibka.enabled = true;
        bool isHidden = Oshibka.GetBool("isHidden");
        Oshibka.SetBool("isHidden", !isHidden);
        StartCoroutine(Osh());
    }

    void D()
    {
        PanePlay1();
        YDText.text = "Вас уволили и вы умерли от ломки!";
        YD.enabled = true;
        bool isHidden = YD.GetBool("isHidden");
        YD.SetBool("isHidden", !isHidden);
    }

    public void Nark_Help()
    {
        ag1 = 0;
        aga = 104;

        gameObject.GetComponent<Timer>().hp.value += 35;
        DontDestroy.Mon += 175;
        StartCoroutine(SAS());
    }

    IEnumerator SAS()
    {
        yield return new WaitForSeconds(1.5f);
        DontDestroy.nark = false;
        ag1 = 3;
        DialogPanel.enabled = true;
        bool isHidden = DialogPanel.GetBool("isHidden");
        DialogPanel.SetBool("isHidden", !isHidden);
        yield return new WaitForSeconds(1.5f);
        Destroy(model.gameObject);
        model = GameObject.FindWithTag("Model");
        Destroy(model.gameObject);
        aga = 0;
        ag1 = 0;
        Timer.last = 0;
    }

    IEnumerator SIS()
    {
        DialogPanel.enabled = true;
        bool isHidden = DialogPanel.GetBool("isHidden");
        DialogPanel.SetBool("isHidden", !isHidden);

        spa = GameObject.FindWithTag("Spa");
        yield return new WaitForSeconds(1.5f);
        Destroy(model.gameObject);
        spa.GetComponent<Spawner>().Clons();
        aga = 0;
        ag1 = 0;
        Timer.last = 0;
    }

    IEnumerator Osh()
    {
        yield return new WaitForSeconds(3.0f);
        Oshibka.enabled = true;
        bool isHidden = Oshibka.GetBool("isHidden");
        Oshibka.SetBool("isHidden", !isHidden);
    }

    void PanePlay1()
    {
        PanelPlay1.enabled = true;
        bool isHidden = PanelPlay1.GetBool("isHidden");
        PanelPlay1.SetBool("isHidden", !isHidden);

        TimePanel1.enabled = true;
        bool izHidden = TimePanel1.GetBool("isHidden");
        TimePanel1.SetBool("isHidden", !izHidden);
    }

}
