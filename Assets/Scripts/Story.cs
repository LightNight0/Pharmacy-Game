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
                KakoiText.text = "Мои старые друзья из группы \"Sexy SeXXX\" позвали меня потусоватся с ними на их концертах, а заодно и под заработать.\n Они будут платит мне за то, чтобы я отбирал по их вкусу девушек, из числа тех, кто хочет пройти за кулисы после концерта, для их \"развлечений\".\n1 - Никаких папарацци. \n2 - Не пропускать несовершеннолетних.";
                KakaiaCel.text = "Моя цель на сегодня: просто потусоваться и немного подзаработать";
                DontDestroy.Zav = 0;
                break;
            case 2:
                StrokaSPodpisu.gameObject.SetActive(false);
                KakoiTyr.text = "Тур Первый";
                KakoiDen.text = "День Тура: Второй";
                KakoiText.text = "Все кайфово, тусуется, заработал, втянулся.\nПознакомился ближе с ребятами: Микки, Джон, Кевин и Valera - отпадные ребята, только и делают что долбят вещества и девушек. А ну еще и музыкой занимаются.\nРебятам вроде нравится как я справляюсь, да и мне тоже приглянулась эта работа, но больше мне нравится сколько мне платят.";
                KakaiaCel.text = "Моя цель на сегодня: продолжать получать удовольствие и деньги.";
                break;
            case 3:
                KakoiTyr.text = "Тур Первый";
                KakoiDen.text = "День Тура: Третий";
                KakoiText.text = "Сегодня последний день их трехдневного тура, я думаю сегодня можно и мне оторваться по полной.\nДумаю можно, после концерта, взять себе что-нибудь для \"веселья\".";
                KakaiaCel.text = "Моя цель на сегодня: ловить кайф и найти себе что-нибудь для \"веселья\".";
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
                KakoiText.text = "В прошлый раз девушка, в виде взятки, дала мне дозу. Я попробовал - словил кайф, еще хочу.\nКевин - гитарист группы, сказал мне что дозу можно купить за 10$ у местного барыги.";
                KakaiaCel.text = "Моя цель на сегодня: заработать 10$ на дозу для кайфа и еще 15$ на ежедневыне расходы.";
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
                KakoiText.text = "Бля, мне что-то плохо после вчерашнего.\nДжон - вокалист группы сказал что есть один есть препарт для интоксикации организма, его можно купить за 10$ у того же местного барыги.\nЯ думаю нужно дунуть чтобы не хуёвило.";
                KakaiaCel.text = "Моя цель на сегодня: заработать 10$ на препарат для интоксикации и еще 10$ на ежедневыне расходы..";
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
                KakoiText.text = "После интоксикации чувствую себя нормально, думаю можно будет еще пару раз словить кайф, а потом можно откатится с помощью интоксикации.";
                KakaiaCel.text = "Моя цель на сегодня: Получать удовольствие и кайф.";
                break;
            case 7:
                KakoiTyr.text = "Тур Второй";
                KakoiDen.text = "День Тура: Четвертый";
                KakoiText.text = "Дело плохо, у меня зависимость, я чувствую как она убивает меня из нутри. Надо что-то с этим делать.";
                KakaiaCel.text = "Моя цель на сегодня: Попытаться что-то разузнать про способы побороть зависимость.";
                break;
            case 8:
                Spawner.ocheredforsujet = 0;
                PersForSujet = 8;
                Move.skokrazoshibsa = 0;
                KakoiTyr.text = "Тур Второй";
                KakoiDen.text = "День Тура: Пятый";
                KakoiText.text = "Вчера от ребят из группы я узнал, что  заработав достаточно денег можно пройти курс лечения и избавиться от зависимости. \nХоть я и чувствую себя не так уж плохо, пора задуматься о своем будещем. ";
                KakaiaCel.text = "Начать копить деньги на лекарство."; //"Моя цель на сегодня:";
                break;
            case 9:
                Spawner.ocheredforsujet = 0;
                PersForSujet = 9;
                KakoiTyr.text = "Тур Второй";
                KakoiDen.text = "День Тура: Шестой";
                KakoiText.text = "Вчера я оказался в затруднительном положении, когда пришла репортерша и предложила большую взятку, но в результате я поступил правильно, когда сделал то, что сделал.";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                break;
            case 10:
                Spawner.ocheredforsujet = 0;
                PersForSujet = 10;
                KakoiTyr.text = "Тур Второй";
                KakoiDen.text = "День Тура: Седьмой";
                KakoiText.text = "Ситуация, что произошла вчера после концерта сильно подкосила мое здоровье. Может можно было совершить иной выбор? Нужно расслабиться, чтобы чувствовать себя лучше.";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                break;
            case 11:
                Spawner.ocheredforsujet = 0;
                if (DontDestroy.report1 == true) PersForSujet = 8;
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
                if (DontDestroy.report2 == true) KakoiText.text = "Вчера снова приходила та журналистка, предложив мне еще больше денег, чем в прошлый раз. Выбор снова был тяжелым, учитывая мою ситуацию. Но я поступил так, как посчитал нужным.";
                else KakoiText.text = "Прошлый день тура был был каким-то скучным и не особо богатым на события. Нужно жить дальше.";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                break;
            case 13:
                Yslovie = 13;
                Spawner.ocheredforsujet = 0;
                PersForSujet = 12;
                KakoiTyr.text = "Тур Третий";
                KakoiDen.text = "День Тура: Третий";
                KakoiText.text = "Приходила девушка, \"самая большая на свете фанатка\", и просила ее пропустить.";
                if (DontDestroy.uberfan == true) KakoiText.text += "Пропустив ее, я получил штраф, но я не ошибся: она сильно понравилась нашим парням, за что мне вернули деньги и даже дали премию.";
                else KakoiText.text += "Я не решился пропускать ее, так каак она не подходила под требования. Может ей повезет в другой раз, надеюсь она не расстроилась.";
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
