using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Story : MonoBehaviour
{
    public GameObject zavbar;
    public GameObject togg1;
    public GameObject togg2;
    public GameObject togg3;
    public Animator PerDna;
    public Animator JurPan;
    public Animator NeVipolnilQuestPan;
    public Text KakoiTyr;
    public Text KakoiDen;
    public Text KakoiText;
    public Text KakaiaCel;
    public Text MQNeVipolnen;

    public Sprite[] sprites = new Sprite[4];
    public GameObject JurnalP;
    public GameObject StrokaSPodpisu;

    int zapomnil = 2;
    int zapomnil2 = 100;

    int Yslovie = 0;
    public static int PersForSujet = 0;

    //Микки - Барабанщик, Кевин - гитарист, Джон - вокалист, Valera - басист.

    // Start is called before the first frame update
    void Start()
    {
        //zavbar.active = false;

        //JIR();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DayS()
    {
        PanJA();
        JIR();
        switch (Timer.provDen)
        {
            case 1:
                JurnalP.GetComponent<Image>().sprite = sprites[2];
                zavbar.gameObject.SetActive(false);
                togg1.gameObject.SetActive(false);
                togg2.gameObject.SetActive(false);
                togg3.gameObject.SetActive(false);
                StrokaSPodpisu.gameObject.SetActive(true);

                KakoiTyr.text = "Тур Первый";
                KakoiDen.text = "День Тура: Первый";
                KakoiText.text = "Один из моих старых друзей из группы \"Sexy SeXXX\" позвал меня потусоватся с группой, а заодно подзаработать.\n Мне будут платить за то, чтобы я отбирал по их вкусу девушек, из числа тех, кто хочет пройти за кулисы после концерта.\n1 - Никаких камер. \n2 - Не пропускать несовершеннолетних.";
                KakaiaCel.text = "Моя цель на сегодня: хорошо провести время и подзаработать";
                DontDestroy.Zav = 0;
                break;
            case 2:
                StrokaSPodpisu.gameObject.SetActive(false);
                KakoiTyr.text = "Тур Первый";
                KakoiDen.text = "День Тура: Второй";
                KakoiText.text = "Мне очень понравился вчерашний вечер, думаю я втянулся!.\nПознакомился со всеми ближе: Микки, Джон, Кевин и Valera - крутые ребята, но только и делают что употребляют и развлекаются.\nРебятам вроде нравится моя работа, да и я вроде бы справляюсь, но больше мне нравится то, сколько мне платят.";
                KakaiaCel.text = "Моя цель на сегодня: продолжать получать удовольствие и зарабатывать.";
                break;
            case 3:
                KakoiTyr.text = "Тур Первый";
                KakoiDen.text = "День Тура: Третий";
                KakoiText.text = "Сегодня будет последний день трехдневного концертного тура, думаю, сегодня и мне можно оторваться по полной.\nПосле работы планирую взять себе что-нибудь для \"веселья\".";
                KakaiaCel.text = "Моя цель на сегодня: наслаждаться жизнью и найти себе что-нибудь для \"веселья\".";
                break;
            case 4:
                Move.skokrazoshibsa = 0;
                Timer.LekBiff = DontDestroy.Lek;
                Timer.MonBiff = DontDestroy.Mon;
                Timer.ZavBiff = DontDestroy.Zav;
                Timer.hpbiff = gameObject.GetComponent<Timer>().hp;
                Timer.zvbiff = gameObject.GetComponent<Timer>().zv;
                Yslovie = 4;

                togg1.gameObject.SetActive(false);
                togg3.gameObject.SetActive(false);

                Timer.Den = 1;
                KakoiTyr.text = "Тур Второй";
                KakoiDen.text = "День Тура: Первый";
                KakoiText.text = "В прошлый раз девушка, в виде взятки, дала мне дозу. Я попробовал - все прошло круто, хочу повторить ещё раз.\nКевин - гитарист группы, сказал мне что дозу можно купить за 10$ у его приятеля.";
                KakaiaCel.text = "Моя цель на сегодня: 10$ на развлечения и еще 15$ на ежедневные расходы.";
                break;
            case 5:
                Timer.LekBiff = DontDestroy.Lek;
                Timer.MonBiff = DontDestroy.Mon;
                Timer.ZavBiff = DontDestroy.Zav;
                Timer.hpbiff = gameObject.GetComponent<Timer>().hp;
                Timer.zvbiff = gameObject.GetComponent<Timer>().zv;
                Yslovie = 5;

                KakoiTyr.text = "Тур Второй";
                KakoiDen.text = "День Тура: Второй";
                KakoiText.text = "Как-то я нехорошо себя чувствую после вчерашнего.\nДжон - вокалист группы сказал что есть один есть препарт для интоксикации организма, его можно купить за 10$ у того же продавца.\nНужно обязательно избавиться от отходняка!";
                KakaiaCel.text = "Моя цель на сегодня: заработать 10$ на препарат для интоксикации и еще 15$ на ежедневные расходы.";
                break;
            case 6:
                Timer.LekBiff = DontDestroy.Lek;
                Timer.MonBiff = DontDestroy.Mon;
                Timer.ZavBiff = DontDestroy.Zav;
                Timer.hpbiff = gameObject.GetComponent<Timer>().hp;
                Timer.zvbiff = gameObject.GetComponent<Timer>().zv;
                gameObject.GetComponent<Timer>().hp.value = 95;
                gameObject.GetComponent<Timer>().zv.value = 6;
                DontDestroy.Zav = 1;

                KakoiTyr.text = "Тур Второй";
                KakoiDen.text = "День Тура: Третий";
                KakoiText.text = "После интоксикации я чуствую себя просто отлично! Думаю, что можно продолжать веселиться, а если станет плохо - всегда можно поправить здоровье интоксикацией.";
                KakaiaCel.text = "Моя цель на сегодня: Получать удовольствие.";
                break;
            case 7:
                KakoiTyr.text = "Тур Второй";
                KakoiDen.text = "День Тура: Четвертый";
                KakoiText.text = "Дело плохо - меня тянет на развлечения всё сильнее. Видимо это и называется зависимость. Я чувствую как она убивает меня изнутри. Надо что-то с этим делать!";
                KakaiaCel.text = "Моя цель на сегодня: Попытаться что-то разузнать про способы побороть зависимость.";
                break;
            case 8:
                Spawner.ocheredforsujet = 0;
                PersForSujet = 8;
                Move.skokrazoshibsa = 0;
                KakoiTyr.text = "Тур Второй";
                KakoiDen.text = "День Тура: Пятый";
                KakoiText.text = "Вчера от ребят из группы я узнал, что  заработав достаточно денег можно пройти курс лечения, избавляющий от зависимости. \nХоть прямо сейчас я чувствую себя неплохо, пора задуматься о своем будещем. ";
                KakaiaCel.text = "Начать копить деньги на лечение."; //"Моя цель на сегодня:";
                break;
            case 9:
                Spawner.ocheredforsujet = 0;
                PersForSujet = 9;
                KakoiTyr.text = "Тур Второй";
                KakoiDen.text = "День Тура: Шестой";
                KakoiText.text = "Вчера, когда пришла репортерша и предложила большую взятку, я сильно сомневался, но в результате принял верное решение, когда сделал то, что сделал.";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                break;
            case 10:
                Spawner.ocheredforsujet = 0;
                PersForSujet = 10;
                KakoiTyr.text = "Тур Второй";
                KakoiDen.text = "День Тура: Седьмой";
                KakoiText.text = "То, что произошло вчера просто в голове не укладывается! После концерта я был сильно избит той \"девушкой\". Может можно было совершить иной выбор? Моё самочувствие просто ужасно. Нужно расслабиться, чтобы чувствовать себя лучше.";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                break;
            case 11:
                Spawner.ocheredforsujet = 0;
                if (DontDestroy.report1 == false) PersForSujet = 8;
                Move.skokrazoshibsa = 0;
                Timer.Den = 1;
                KakoiTyr.text = "Тур Третий";
                KakoiDen.text = "День Тура: Первый";
                KakoiText.text = "Мне хорошо запомнился последний день прошлого тура. Приходила девушка, просящая денег на лекарство.\n";
                if (DontDestroy.nark == true) KakoiText.text += "Я дал в долг странной девушке, даже не знаю зачем. Может я ошибся, вернется ли эта девушка снова?";
                else KakoiText.text += "Я прогнал странную девушку, просящую денег в долг. Я нахожусь в такой же ситуации, и собственная жизнь мне дороже. Надеюсь я поступил правильно.";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                break;
            case 12:
                Spawner.ocheredforsujet = 0;
                PersForSujet = 11;
                KakoiTyr.text = "Тур Третий";
                KakoiDen.text = "День Тура: Второй";
                if (DontDestroy.report2 == true) KakoiText.text = "Вчера снова приходила та журналистка, что предлагала взятку, в этот раз предложив мне еще больше денег. Выбор снова был тяжелым, учитывая мою цель и плохое самочувствие. Но я поступил так, как посчитал правильным.";
                else KakoiText.text = "Прошлый день тура был был самым обычным, даже скучным, и не особо богатым на события. Нужно жить дальше.";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                break;
            case 13:
                Yslovie = 13;
                Spawner.ocheredforsujet = 0;
                PersForSujet = 12;
                KakoiTyr.text = "Тур Третий";
                KakoiDen.text = "День Тура: Третий";
                KakoiText.text = "Приходила девушка, назвавшая себя \"самая большая на свете фанатка\", и просила ее пропустить.";
                if (DontDestroy.uberfan == true) KakoiText.text += "Пропустив ее, я получил штраф, но я не ошибся: она сильно понравилась нашим парням, за что мне вернули деньги и даже дали премию.";
                else KakoiText.text += "Я не решился пропускать ее, так как она не подходила под требования. Может ей повезет в другой раз, надеюсь она не расстроилась.";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                break;
            case 14:
                Spawner.ocheredforsujet = 0;
                PersForSujet = 13;
                KakoiTyr.text = "Тур Третий";
                KakoiDen.text = "День Тура: Четвертый";
                KakoiText.text = "Вчера произошла очень странная ситуация. Пришедшая девушка убеждала меня, что она беременна от вокалиста группы.\nЯ не пропустил ее - с такими делами пускай она связывается с адвокатом, или обращается к менеджеру.";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                break;
            case 15:
                KakoiTyr.text = "Тур Третий";
                KakoiDen.text = "День Тура: Пятый";
                KakoiText.text = "Прошедший день был вполне обычным.";
                if (DontDestroy.uberfan == true) KakoiText.text += "Пропустив пришедшего менеджера я принес огромную пользу группе, за что был премирован. Все были мной довольны.";
                else KakoiText.text += "Разве что пришел менеджер, которого я, на всякий случай, не пропустил. Больше ничего необычного.";
                KakoiText.text += "\nСегодня группа отыгрывает последний день тура, концерт самый крупный из всех, это будет ой как непросто.";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                break;
            case 16:
                //конец игры
                SceneManager.LoadScene("Titri");
                break;
        }
    }

    void JIR()
    {
        int vibor;
        vibor = UnityEngine.Random.Range(0, 4);
        if (vibor != zapomnil && vibor != zapomnil2)
        {
            zapomnil2 = zapomnil;
            zapomnil = vibor;
            JurnalP.GetComponent<Image>().sprite = sprites[vibor];
        }
        else JIR();
    }

    public void PanJA()
    {
        JurPan.enabled = true;
        bool ijHidden = JurPan.GetBool("isHidden");
        JurPan.SetBool("isHidden", !ijHidden);
    }

    public void VklPls()
    {
        switch(Timer.provDen)
        {
            case 4:
                zavbar.gameObject.SetActive(true);
                togg2.gameObject.SetActive(true);
                break;
            case 5:
                togg1.gameObject.SetActive(true);
                break;
            case 8:
                togg3.gameObject.SetActive(true);
                break;
        }
    }

    public void MyQuest()
    {
        switch(Yslovie)
        {
            case 0:
                gameObject.GetComponent<Timer>().Podschet();
                gameObject.GetComponent<Timer>().PanelSt();
                Yslovie = 1;
                break;
            case 1:
                Yslovie = 0;
                DayS();
                break;
            case 4:
                if (DontDestroy.Mon < 25)
                {
                    MQNeVipolnen.text = "Собственное задание проваленно! \n Ты не смог накопить 25$!";
                    Timer.provDen = 4;
                    DontDestroy.Lek = Timer.LekBiff;
                    DontDestroy.Mon = Timer.MonBiff;
                    DontDestroy.Zav = Timer.ZavBiff;
                    gameObject.GetComponent<Timer>().hp = Timer.hpbiff;
                    gameObject.GetComponent<Timer>().zv = Timer.zvbiff;
                    PanMQ();
                }
                else
                {
                    Yslovie = 41;
                    gameObject.GetComponent<Timer>().PanelSt();
                    gameObject.GetComponent<Timer>().hp.value = 95.0f;
                    Timer.hpbuf = gameObject.GetComponent<Timer>().hp.value;                   
                    gameObject.GetComponent<Timer>().Podschet();
                }
                break;
            case 41:
                if (gameObject.GetComponent<Timer>().Dru.isOn == false)
                {
                    MQNeVipolnen.text = "Собственное задание проваленно! \n Ты не купил веществ!";
                    Timer.provDen = 4;
                    DontDestroy.Lek = Timer.LekBiff;
                    DontDestroy.Mon = Timer.MonBiff;
                    DontDestroy.Zav = Timer.ZavBiff;
                    gameObject.GetComponent<Timer>().hp = Timer.hpbiff;
                    gameObject.GetComponent<Timer>().zv = Timer.zvbiff;
                    PanMQ();
                }
                else
                {
                    Yslovie = 0;
                    DayS();
                }
                break;
            case 5:
                if (DontDestroy.Mon < 20)
                {
                    MQNeVipolnen.text = "Собственное задание проваленно! \n Ты не смог накопить 20$!";
                    Timer.provDen = 5;
                    DontDestroy.Lek = Timer.LekBiff;
                    DontDestroy.Mon = Timer.MonBiff;
                    DontDestroy.Zav = Timer.ZavBiff;
                    gameObject.GetComponent<Timer>().hp = Timer.hpbiff;
                    gameObject.GetComponent<Timer>().zv = Timer.zvbiff;
                    PanMQ();
                }
                else
                {
                    Yslovie = 51;
                    gameObject.GetComponent<Timer>().PanelSt();
                    gameObject.GetComponent<Timer>().hp.value = 100.0f;
                    Timer.hpbuf = gameObject.GetComponent<Timer>().hp.value;
                    gameObject.GetComponent<Timer>().Podschet();
                }
                break;
            case 51:
                if (gameObject.GetComponent<Timer>().Med.isOn == false)
                {
                    MQNeVipolnen.text = "Собственное задание проваленно! \n Ты не купил лекарство!";
                    Timer.provDen = 4;
                    DontDestroy.Lek = Timer.LekBiff;
                    DontDestroy.Mon = Timer.MonBiff;
                    DontDestroy.Zav = Timer.ZavBiff;
                    gameObject.GetComponent<Timer>().hp = Timer.hpbiff;
                    gameObject.GetComponent<Timer>().zv = Timer.zvbiff;
                    PanMQ();
                }
                else
                {
                    Yslovie = 0;
                    DayS();
                }
                break;
            case 13:
                if (DontDestroy.pregant == true)
                {
                    DontDestroy.Mon -= 150;
                    gameObject.GetComponent<Timer>().Podschet();
                    gameObject.GetComponent<Timer>().PanelSt();
                    Yslovie = 131;
                }
                else
                {
                    Yslovie = 0;
                    DayS();
                }
                break;
            case 131:
                Yslovie = 0;
                gameObject.GetComponent<Timer>().PanelSt();
                PerehoDik();
                break;
        }
    }

    public void PanMQ()
    {
        NeVipolnilQuestPan.enabled = true;
        bool ijHidden = NeVipolnilQuestPan.GetBool("isHidden");
        NeVipolnilQuestPan.SetBool("isHidden", !ijHidden);
    }

    public void PerehoDik()
    {
        PerDna.enabled = true;
        bool ijHidden = PerDna.GetBool("isHidden");
        PerDna.SetBool("isHidden", !ijHidden);
    }
}
