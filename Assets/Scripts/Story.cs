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
    public Sprite[] maps = new Sprite[15];
    public GameObject JurnalP;
    public GameObject StrokaSPodpisu;
    public GameObject spawn;

    public GameObject knopkaDal;
    public GameObject knopkaDalMap;
    public GameObject knopkaNaz;
    public GameObject gorod;
    public GameObject skokdevok;
    public GameObject KakTamDevki;
    int KakovDenMap = 0;
    int zapvibkar = 0;

    int zapomnil = 2;
    int zapomnil2 = 100;
    public static int[] skokpropdev = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

    int Yslovie = 0;
    public static int PersForSujet = 0;
    bool DnevnikVopros = true;

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
        if (DnevnikVopros == true) PanJA();
        if (DnevnikVopros == true) JIR();
        string[] strArr = new string[4] { "Пускать только блондинок.", "Пускать только брюнеток.", "Пускать рыжих девушек.", "Пускать девушек." };
        string[] strArr2 = new string[4] { "Пускать только тру-фанаток.", "Пускать только девушек со стаффом: ", "Пускать девушек с возрастом меньше ", "Пускать девушек с возрастом больше " };
        switch (Timer.provDen)
        {
            case 1:
                KakovDenMap = Timer.provDen;
                DontDestroy.actII = false;
                DontDestroy.actIII = false;
                DontDestroy.Titri = false;
                Move.zadanie1 = 4;
                Move.zadanie2 = 0;
                Move.zadanie3 = 0;
                gameObject.GetComponent<Timer>().DayQuest.text = strArr[Move.zadanie1 - 1];
                gameObject.GetComponent<Timer>().DayQuest2.text = strArr[Move.zadanie1 - 1];

                JurnalP.GetComponent<Image>().sprite = sprites[2];
                zavbar.gameObject.SetActive(false);
                togg1.gameObject.SetActive(false);
                togg2.gameObject.SetActive(false);
                togg3.gameObject.SetActive(false);
                StrokaSPodpisu.gameObject.SetActive(true);

                KakoiTyr.text = "Тур в поддержку альбома";
                KakoiDen.text = "День Первый";
                KakoiText.text = "Один из моих старых друзей из группы \"Sexy SeXXX\" предложил мне подзаработать.\n Мне будут платить за то, что я отбираю девушек из тех, кто хочет пройти за кулисы.\n1 - Никаких камер. \n2 - Не пропускать несовершеннолетних.";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                DontDestroy.Zav = 0;
                break;
            case 2:
                KakovDenMap = Timer.provDen;
                Move.zadanie1 = 2;
                Move.zadanie2 = 0;
                Move.zadanie3 = 0;
                gameObject.GetComponent<Timer>().DayQuest.text = strArr[Move.zadanie1 - 1];
                gameObject.GetComponent<Timer>().DayQuest2.text = strArr[Move.zadanie1 - 1];

                StrokaSPodpisu.gameObject.SetActive(false);
                KakoiTyr.text = "Тур в поддержку альбома";
                KakoiDen.text = "День Второй";
                KakoiText.text = "Мне очень понравился вчерашний вечер!.\nПознакомился со всеми ближе: Микки, Джон, Кевин и Valera - крутые ребята, но только и делают что употребляют и развлекаются. \nВсем нравится моя работа, да и я вроде бы справляюсь, но больше мне нравится то, сколько мне платят.";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                break;
            case 3:
                KakovDenMap = Timer.provDen;
                PersForSujet = 22;
                Spawner.ocheredforsujet = 0;

                Move.zadanie1 = 4;
                Move.zadanie2 = 1;//23
                Move.zadanie3 = 0;
                gameObject.GetComponent<Timer>().DayQuest.text = strArr[Move.zadanie1 - 1];
                gameObject.GetComponent<Timer>().DayQuest2.text = strArr[Move.zadanie1 - 1];
                gameObject.GetComponent<Timer>().DayQuest.text += "                                        " + strArr2[0];
                gameObject.GetComponent<Timer>().DayQuest2.text += "                                        " + strArr2[0];
                //gameObject.GetComponent<Timer>().DayQuest.text += "любым";
                //gameObject.GetComponent<Timer>().DayQuest2.text += "любым";

                KakoiTyr.text = "Тур в поддержку альбома";
                KakoiDen.text = "День Третий";
                KakoiText.text = "Сегодня будет последний день трехдневного концертного тура, думаю, сегодня и мне можно оторваться по полной.\nПосле работы планирую взять себе что-нибудь для \"веселья\".";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                break;
            case 4:
                KakovDenMap = Timer.provDen;
                togg1.gameObject.SetActive(false);
                togg3.gameObject.SetActive(false);
                Timer.Den = 1;
                KakoiTyr.text = "Тур \"Восточное побережье\"";
                KakoiDen.text = "День Первый";
                KakoiText.text = "В прошлый раз девушка, в виде взятки, дала мне дозу. Я попробовал - все прошло круто, хочу повторить ещё раз.\nКевин - гитарист группы, сказал мне что дозу можно купить за 10$ у его приятеля.";
                KakaiaCel.text = "Моя цель на сегодня: 10$ на развлечения и еще 15$ на ежедневные расходы.";

                DontDestroy.actII = true;
                DontDestroy.MonAct[0] = DontDestroy.Mon;
                //DontDestroy.LekAct[0] = DontDestroy.Lek;
                //DontDestroy.ZavAct[0] = DontDestroy.Zav;
                //DontDestroy.HpAct[0].value = gameObject.GetComponent<Timer>().hp.value;
                //DontDestroy.ZvAct[0].value = gameObject.GetComponent<Timer>().zv.value;
                Move.zadanie1 = 1;
                Move.zadanie2 = 23;
                Move.zadanie3 = 0;
                gameObject.GetComponent<Timer>().DayQuest.text = strArr[Move.zadanie1 - 1];
                gameObject.GetComponent<Timer>().DayQuest2.text = strArr[Move.zadanie1 - 1];
                gameObject.GetComponent<Timer>().DayQuest.text += "                                        " + strArr2[1];
                gameObject.GetComponent<Timer>().DayQuest2.text += "                                        " + strArr2[1];
                gameObject.GetComponent<Timer>().DayQuest.text += "любым";
                gameObject.GetComponent<Timer>().DayQuest2.text += "любым";

                Move.skokrazoshibsa = 0;
                Timer.LekBiff = DontDestroy.Lek;
                Timer.MonBiff = DontDestroy.Mon;
                Timer.ZavBiff = DontDestroy.Zav;
                Timer.hpbiff = gameObject.GetComponent<Timer>().hp;
                Timer.zvbiff = gameObject.GetComponent<Timer>().zv;
                Yslovie = 4;
                break;
            case 5:
                KakovDenMap = Timer.provDen;
                Move.zadanie1 = 4;
                Move.zadanie2 = 20;
                Move.zadanie3 = 0;
                gameObject.GetComponent<Timer>().DayQuest.text = strArr[Move.zadanie1 - 1];
                gameObject.GetComponent<Timer>().DayQuest2.text = strArr[Move.zadanie1 - 1];
                gameObject.GetComponent<Timer>().DayQuest.text += "                                        " + strArr2[1];
                gameObject.GetComponent<Timer>().DayQuest2.text += "                                        " + strArr2[1];
                gameObject.GetComponent<Timer>().DayQuest.text += ModelsBio.ves[0];
                gameObject.GetComponent<Timer>().DayQuest2.text += ModelsBio.ves[0];

                Timer.LekBiff = DontDestroy.Lek;
                Timer.MonBiff = DontDestroy.Mon;
                Timer.ZavBiff = DontDestroy.Zav;
                Timer.hpbiff = gameObject.GetComponent<Timer>().hp;
                Timer.zvbiff = gameObject.GetComponent<Timer>().zv;
                Yslovie = 5;

                KakoiTyr.text = "Тур \"Восточное побережье\"";
                KakoiDen.text = "День Второй";
                KakoiText.text = "Как-то я нехорошо себя чувствую после вчерашнего.\nДжон - вокалист группы сказал что есть один есть препарт для интоксикации организма, его можно купить за 10$ у того же продавца.\nНужно обязательно избавиться от отходняка!";
                KakaiaCel.text = "Моя цель на сегодня: 10$ на препарат для интоксикации и еще 15$ на ежедневные расходы.";
                break;
            case 6:
                KakovDenMap = Timer.provDen;
                gameObject.GetComponent<Timer>().Quest();
                Timer.LekBiff = DontDestroy.Lek;
                Timer.MonBiff = DontDestroy.Mon;
                Timer.ZavBiff = DontDestroy.Zav;
                Timer.hpbiff = gameObject.GetComponent<Timer>().hp;
                Timer.zvbiff = gameObject.GetComponent<Timer>().zv;
                gameObject.GetComponent<Timer>().hp.value = 95;
                gameObject.GetComponent<Timer>().zv.value = 6;
                DontDestroy.Zav = 1;

                KakoiTyr.text = "Тур \"Восточное побережье\"";
                KakoiDen.text = "День Третий";
                KakoiText.text = "После интоксикации я чуствую себя просто отлично! Думаю, что можно продолжать веселиться, а если станет плохо - всегда можно поправить здоровье интоксикацией.";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                break;
            case 7:
                KakovDenMap = Timer.provDen;
                gameObject.GetComponent<Timer>().Quest();
                KakoiTyr.text = "Тур \"Восточное побережье\"";
                KakoiDen.text = "День Четвертый";
                KakoiText.text = "Дело плохо - меня тянет на развлечения всё сильнее. Я чувствую что у меня началась зависимость. Надо что-то с этим делать! Стоит узнать что-нибудь о способах её побороть.";
                // KakaiaCel.text = "Моя цель на сегодня: Попытаться что-то разузнать про способы побороть зависимость.";\
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                break;
            case 8:
                KakovDenMap = Timer.provDen;
                gameObject.GetComponent<Timer>().Quest();
                Spawner.ocheredforsujet = 0;
                PersForSujet = 8;
                Move.skokrazoshibsa = 0;
                KakoiTyr.text = "Тур \"Восточное побережье\"";
                KakoiDen.text = "День Пятый";
                KakoiText.text = "Вчера от ребят из группы я узнал, что  заработав достаточно денег можно пройти курс лечения, избавляющий от зависимости. \nХоть прямо сейчас я чувствую себя неплохо, пора задуматься о своем будещем. ";
                //KakaiaCel.text = "Начать копить деньги на лечение."; //"Моя цель на сегодня:";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                break;
            case 9:
                KakovDenMap = Timer.provDen;
                gameObject.GetComponent<Timer>().Quest();
                Spawner.ocheredforsujet = 0;
                PersForSujet = 9;
                KakoiTyr.text = "Тур \"Восточное побережье\"";
                KakoiDen.text = "День Шестой";
                KakoiText.text = "Вчера, когда пришла репортерша и предложила большую взятку, я сильно сомневался, но в результате принял верное решение, когда сделал то, что сделал.";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                break;
            case 10:
                KakovDenMap = Timer.provDen;
                gameObject.GetComponent<Timer>().Quest();
                Spawner.ocheredforsujet = 0;
                PersForSujet = 10;
                KakoiTyr.text = "Тур \"Восточное побережье\"";
                KakoiDen.text = "День Седьмой";
                KakoiText.text = "То, что произошло вчера просто в голове не укладывается! После концерта я был сильно избит той \"девушкой\". Может можно было совершить иной выбор? Моё самочувствие просто ужасно. Нужно расслабиться, чтобы чувствовать себя лучше.";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                break;
            case 11:
                KakovDenMap = Timer.provDen;
                if (DontDestroy.nark == true && gameObject.GetComponent<Timer>().hp.value <= 30) spawn.GetComponent<Spawner>().SpawnSuj3();
                gameObject.GetComponent<Timer>().Quest();
                if (DontDestroy.report1 == false) Spawner.ocheredforsujet = 0;
                if (DontDestroy.report1 == false) PersForSujet = 8;
                Move.skokrazoshibsa = 0;
                Timer.Den = 1;
                KakoiTyr.text = "Тур \"Средний Запад\"";
                KakoiDen.text = "День Первый";
                KakoiText.text = "Мне хорошо запомнился последний день прошлого тура. Приходила девушка, просящая денег на лекарство.\n";
                if (DontDestroy.nark == true) KakoiText.text += "Я дал в долг странной девушке, даже не знаю зачем. Может я ошибся, вернется ли эта девушка снова?";
                else KakoiText.text += "Я прогнал странную девушку, просящую денег в долг. Я нахожусь в такой же ситуации, и собственная жизнь мне дороже. Надеюсь я поступил правильно.";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                DontDestroy.actIII = true;
                DontDestroy.MonAct[1] = DontDestroy.Mon;
                DontDestroy.LekAct[1] = DontDestroy.Lek;
                DontDestroy.ZavAct[1] = DontDestroy.Zav;
                DontDestroy.HpAct = gameObject.GetComponent<Timer>().hp.value;
                DontDestroy.ZvAct = gameObject.GetComponent<Timer>().zv.value;
                break;
            case 12:
                KakovDenMap = Timer.provDen;
                if (DontDestroy.nark == true && gameObject.GetComponent<Timer>().hp.value <= 30) spawn.GetComponent<Spawner>().SpawnSuj3();
                gameObject.GetComponent<Timer>().Quest();
                Spawner.ocheredforsujet = 0;
                PersForSujet = 11;
                KakoiTyr.text = "Тур \"Средний Запад\"";
                KakoiDen.text = "День Второй";
                if (DontDestroy.report2 == true && DontDestroy.report1 == false) KakoiText.text = "Вчера снова приходила та журналистка, что предлагала взятку, в этот раз предложив мне еще больше денег. Выбор снова был тяжелым, учитывая мою цель и плохое самочувствие. Но я поступил так, как посчитал правильным.";
                else KakoiText.text = "Прошлый день тура был был самым обычным, даже скучным, и не особо богатым на события. ";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                break;
            case 13:
                KakovDenMap = Timer.provDen;
                if (DontDestroy.nark == true && gameObject.GetComponent<Timer>().hp.value <= 30) spawn.GetComponent<Spawner>().SpawnSuj3();
                gameObject.GetComponent<Timer>().Quest();
                Yslovie = 13;
                Spawner.ocheredforsujet = 0;
                PersForSujet = 12;
                KakoiTyr.text = "Тур \"Средний Запад\"";
                KakoiDen.text = "День Третий";
                KakoiText.text = "Приходила девушка, назвавшая себя \"самая большая на свете фанатка\", и просила ее пропустить.";
                if (DontDestroy.uberfan == true)
                {
                    KakoiText.text += "Пропустив ее, я получил штраф, но я не ошибся: она сильно понравилась нашим парням, за что мне вернули деньги и даже дали премию.";
                    DontDestroy.Mon += 275;
                }
                else KakoiText.text += "Я не решился пропускать ее, так как она не подходила под требования. Может ей повезет в другой раз, надеюсь она не расстроилась.";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                break;
            case 14:
                KakovDenMap = Timer.provDen;
                if (DontDestroy.nark == true && gameObject.GetComponent<Timer>().hp.value <= 30) spawn.GetComponent<Spawner>().SpawnSuj3();
                gameObject.GetComponent<Timer>().Quest();
                Spawner.ocheredforsujet = 0;
                PersForSujet = 13;
                KakoiTyr.text = "Тур \"Средний Запад\"";
                KakoiDen.text = "День Четвертый";
                KakoiText.text = "Вчера произошла очень странная ситуация. Пришедшая девушка убеждала меня, что она беременна от вокалиста группы.\nЯ не пропустил ее - с такими делами пускай она связывается с адвокатом, или обращается к менеджеру.";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                Move.zadanie1 = 1;
                break;
            case 15:
                KakovDenMap = Timer.provDen;
                if (DontDestroy.nark == true && gameObject.GetComponent<Timer>().hp.value <= 30) spawn.GetComponent<Spawner>().SpawnSuj3();
                gameObject.GetComponent<Timer>().Quest();
                KakoiTyr.text = "Тур \"Средний Запад\"";
                KakoiDen.text = "День Пятый";
                KakoiText.text = "Прошедший день был вполне обычным. ";
                if (DontDestroy.uberfan == true) KakoiText.text += "Пропустив пришедшего менеджера я принес огромную пользу группе, за что был премирован. Все были мной довольны.";
                else KakoiText.text += "Разве что пришел менеджер, которого я, на всякий случай, не пропустил. Больше ничего необычного.";
                if (DontDestroy.pregant == true) KakoiText.text = "Прошлый день я польностью пропустил из-за произошедшей ситуации...";
                KakoiText.text += "\nСегодня группа отыгрывает последний день тура, концерт самый крупный из всех, это будет ой как непросто.";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                break;
            case 16:
                //конец игры
                DontDestroy.Titri = true;
                SceneManager.LoadScene("Koncovki");
                break;
        }
        DnevnikVopros = true;
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
            zapvibkar = vibor;
        }
        else JIR();
    }

    public void JuJu()
    {
        DnevnikVopros = false;
        knopkaDal.gameObject.SetActive(true);
        knopkaDalMap.gameObject.SetActive(false);
        knopkaNaz.gameObject.SetActive(false);
        gorod.gameObject.SetActive(false);
        skokdevok.gameObject.SetActive(false);
        KakTamDevki.gameObject.SetActive(false);
        KakTamDevki.gameObject.SetActive(false);
        KakovDenMap = 0;
        JurnalP.GetComponent<Image>().sprite = sprites[zapvibkar];
        DayS();
    }

    public void DalsMap()
    {
        if (Timer.provDen > KakovDenMap) KakovDenMap += 1;
        JuMap();
    }

    public void NazMap()
    {
        KakovDenMap -= 1;
        JuMap();
    }

    public void JuMap()
    {
        KakTamDevki.gameObject.SetActive(false);
        StrokaSPodpisu.gameObject.SetActive(false);
        knopkaDal.gameObject.SetActive(false);
        knopkaDalMap.gameObject.SetActive(true);
        knopkaNaz.gameObject.SetActive(true);
        gorod.gameObject.SetActive(true);
        skokdevok.gameObject.SetActive(true);
        skokdevok.GetComponent<Text>().text = "Девушек было пропущенно: " + skokpropdev[KakovDenMap - 1];
        if (KakovDenMap == Timer.provDen) knopkaDalMap.gameObject.SetActive(false);
        switch (KakovDenMap)
        {
            case 1:
                knopkaNaz.gameObject.SetActive(false);
                JurnalP.GetComponent<Image>().sprite = maps[0];
                gorod.GetComponent<Text>().text = "Сегодня: Солт-Лейк-Сити!";
                KakoiTyr.text = "Тур в поддержку альбома";
                KakoiDen.text = "День Первый";
                KakoiText.text = "Один из моих старых друзей из группы \"Sexy SeXXX\" предложил мне подзаработать.\n Мне будут платить за то, что я отбираю девушек из тех, кто хочет пройти за кулисы.\n1 - Никаких камер. \n2 - Не пропускать несовершеннолетних.";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                break;
            case 2:
                JurnalP.GetComponent<Image>().sprite = maps[1];
                gorod.GetComponent<Text>().text = "Сегодня: Денвер!";
                KakoiTyr.text = "Тур в поддержку альбома";
                KakoiDen.text = "День Второй";
                KakoiText.text = "Мне очень понравился вчерашний вечер!.\nПознакомился со всеми ближе: Микки, Джон, Кевин и Valera - крутые ребята, но только и делают что употребляют и развлекаются. \nВсем нравится моя работа, да и я вроде бы справляюсь, но больше мне нравится то, сколько мне платят.";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                break;
            case 3:
                JurnalP.GetComponent<Image>().sprite = maps[2];
                gorod.GetComponent<Text>().text = "Сегодня: Омаха!";
                KakoiTyr.text = "Тур в поддержку альбома";
                KakoiDen.text = "День Третий";
                KakoiText.text = "Сегодня будет последний день трехдневного концертного тура, думаю, сегодня и мне можно оторваться по полной.\nПосле работы планирую взять себе что-нибудь для \"веселья\".";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                break;
            case 4:
                JurnalP.GetComponent<Image>().sprite = maps[3];
                gorod.GetComponent<Text>().text = "Сегодня: Атланта!";
                KakoiTyr.text = "Тур \"Восточное побережье\"";
                KakoiDen.text = "День Первый";
                KakoiText.text = "В прошлый раз девушка, в виде взятки, дала мне дозу. Я попробовал - все прошло круто, хочу повторить ещё раз.\nКевин - гитарист группы, сказал мне что дозу можно купить за 10$ у его приятеля.";
                KakaiaCel.text = "";
                break;
            case 5:
                JurnalP.GetComponent<Image>().sprite = maps[4];
                gorod.GetComponent<Text>().text = "Сегодня: Шарлотт!";
                KakoiTyr.text = "Тур \"Восточное побережье\"";
                KakoiDen.text = "День Второй";
                KakoiText.text = "Как-то я нехорошо себя чувствую после вчерашнего.\nДжон - вокалист группы сказал что есть один есть препарт для интоксикации организма, его можно купить за 10$ у того же продавца.\nНужно обязательно избавиться от отходняка!";
                KakaiaCel.text = "";
                break;
            case 6:
                JurnalP.GetComponent<Image>().sprite = maps[5];
                gorod.GetComponent<Text>().text = "Сегодня: Гринсборо!";
                KakoiTyr.text = "Тур \"Восточное побережье\"";
                KakoiDen.text = "День Третий";
                KakoiText.text = "После интоксикации я чуствую себя просто отлично! Думаю, что можно продолжать веселиться, а если станет плохо - всегда можно поправить здоровье интоксикацией.";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                break;
            case 7:
                JurnalP.GetComponent<Image>().sprite = maps[6];
                gorod.GetComponent<Text>().text = "Сегодня: Вашингтон!";
                KakoiTyr.text = "Тур \"Восточное побережье\"";
                KakoiDen.text = "День Четвертый";
                KakoiText.text = "Дело плохо - меня тянет на развлечения всё сильнее. Я чувствую что у меня началась зависимость. Надо что-то с этим делать! Стоит узнать что-нибудь о способах её побороть.";
                // KakaiaCel.text = "Моя цель на сегодня: Попытаться что-то разузнать про способы побороть зависимость.";\
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                break;
            case 8:
                KakTamDevki.gameObject.SetActive(true);
                if (DontDestroy.report1 == true) KakTamDevki.GetComponent<Text>().text = "Журналистка прошла за кулисы - Да";
                if (DontDestroy.report1 == false) KakTamDevki.GetComponent<Text>().text = "Журналистка прошла за кулисы - Нет";
                JurnalP.GetComponent<Image>().sprite = maps[7];
                gorod.GetComponent<Text>().text = "Сегодня: Балтимор!";
                KakoiTyr.text = "Тур \"Восточное побережье\"";
                KakoiDen.text = "День Пятый";
                KakoiText.text = "Вчера от ребят из группы я узнал, что  заработав достаточно денег можно пройти курс лечения, избавляющий от зависимости. \nХоть прямо сейчас я чувствую себя неплохо, пора задуматься о своем будещем. ";
                //KakaiaCel.text = "Начать копить деньги на лечение."; //"Моя цель на сегодня:";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                break;
            case 9:
                JurnalP.GetComponent<Image>().sprite = maps[8];
                gorod.GetComponent<Text>().text = "Сегодня: Филадельфия!";
                KakoiTyr.text = "Тур \"Восточное побережье\"";
                KakoiDen.text = "День Шестой";
                KakoiText.text = "Вчера, когда пришла репортерша и предложила большую взятку, я сильно сомневался, но в результате принял верное решение, когда сделал то, что сделал.";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                break;
            case 10:
                KakTamDevki.gameObject.SetActive(true);
                JurnalP.GetComponent<Image>().sprite = maps[9];
                gorod.GetComponent<Text>().text = "Сегодня: Нью-Йорк!";
                KakoiTyr.text = "Тур \"Восточное побережье\"";
                KakoiDen.text = "День Седьмой";
                KakoiText.text = "То, что произошло вчера просто в голове не укладывается! После концерта я был сильно избит той \"девушкой\". Может можно было совершить иной выбор? Моё самочувствие просто ужасно. Нужно расслабиться, чтобы чувствовать себя лучше.";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                if (DontDestroy.nark == true)
                {
                    KakTamDevki.GetComponent<Text>().text = "Девушка-наркоманка получила помощь - Да";
                }
                else
                {
                    KakTamDevki.GetComponent<Text>().text = "Девушка-наркоманка получила помощь - Нет";
                }
                break;
            case 11:
                //KakTamDevki.gameObject.SetActive(true);
                JurnalP.GetComponent<Image>().sprite = maps[10];
                gorod.GetComponent<Text>().text = "Сегодня: Порт-Гурон!";
                KakoiTyr.text = "Тур \"Средний Запад\"";
                KakoiDen.text = "День Первый";
                KakoiText.text = "Мне хорошо запомнился последний день прошлого тура. Приходила девушка, просящая денег на лекарство.\n";
                if (DontDestroy.nark == true)
                {
                    KakoiText.text += "Я дал в долг странной девушке, даже не знаю зачем. Может я ошибся, вернется ли эта девушка снова?";
                }
                else
                {
                    KakoiText.text += "Я прогнал странную девушку, просящую денег в долг. Я нахожусь в такой же ситуации, и собственная жизнь мне дороже. Надеюсь я поступил правильно.";
                }
                if (DontDestroy.report2 == true && DontDestroy.report1 == false)
                {
                    KakTamDevki.gameObject.SetActive(true);
                    KakTamDevki.GetComponent<Text>().text = "Журналистка прошла за кулисы - Да";
                }
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                break;
            case 12:
                KakTamDevki.gameObject.SetActive(true);
                JurnalP.GetComponent<Image>().sprite = maps[11];
                gorod.GetComponent<Text>().text = "Сегодня: Понтиак!";
                KakoiTyr.text = "Тур \"Средний Запад\"";
                KakoiDen.text = "День Второй";
                if (DontDestroy.report2 == true && DontDestroy.report1 == false)
                {
                    KakoiText.text = "Вчера снова приходила та журналистка, что предлагала взятку, в этот раз предложив мне еще больше денег. Выбор снова был тяжелым, учитывая мою цель и плохое самочувствие. Но я поступил так, как посчитал правильным.";
                }
                else KakoiText.text = "Прошлый день тура был был самым обычным, даже скучным, и не особо богатым на события. ";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                if (DontDestroy.uberfan == true)
                {
                    KakTamDevki.GetComponent<Text>().text = "Фанатка пропущенна за кулисы - Да";
                }
                else
                {
                    KakTamDevki.GetComponent<Text>().text = "Фанатка пропущенна за кулисы - Нет";
                }
                break;
            case 13:
                JurnalP.GetComponent<Image>().sprite = maps[12];
                gorod.GetComponent<Text>().text = "Сегодня: Детройт!";
                KakoiTyr.text = "Тур \"Средний Запад\"";
                KakoiDen.text = "День Третий";
                KakoiText.text = "Приходила девушка, назвавшая себя \"самая большая на свете фанатка\", и просила ее пропустить.";
                if (DontDestroy.uberfan == true)
                {
                    KakoiText.text += "Пропустив ее, я получил штраф, но я не ошибся: она сильно понравилась нашим парням, за что мне вернули деньги и даже дали премию.";
                }
                else
                {
                    KakoiText.text += "Я не решился пропускать ее, так как она не подходила под требования. Может ей повезет в другой раз, надеюсь она не расстроилась.";
                }
                KakTamDevki.gameObject.SetActive(true);
                KakTamDevki.GetComponent<Text>().text = "Беременная прошла внутрь - Нет";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                break;
            case 14:
                KakTamDevki.gameObject.SetActive(true);
                JurnalP.GetComponent<Image>().sprite = maps[13];
                gorod.GetComponent<Text>().text = "Сегодня: Чикаго!";
                KakoiTyr.text = "Тур \"Средний Запад\"";
                KakoiDen.text = "День Четвертый";
                KakoiText.text = "Вчера произошла очень странная ситуация. Пришедшая девушка убеждала меня, что она беременна от вокалиста группы.\nЯ не пропустил ее - с такими делами пускай она связывается с адвокатом, или обращается к менеджеру.";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                if (DontDestroy.uberfan == true)
                {
                    KakTamDevki.GetComponent<Text>().text = "Пиар-менеджер пропущенна за кулисы - Да";
                }
                else
                {
                    KakTamDevki.GetComponent<Text>().text = "Пиар-менеджер пропущенна за кулисы - Нет";
                }
                break;
            case 15:
                JurnalP.GetComponent<Image>().sprite = maps[14];
                gorod.GetComponent<Text>().text = "Сегодня: Канзас-Сити!";
                KakoiTyr.text = "Тур \"Средний Запад\"";
                KakoiDen.text = "День Пятый";
                KakoiText.text = "Прошедший день был вполне обычным. ";
                if (DontDestroy.uberfan == true)
                {
                    KakoiText.text += "Пропустив пришедшего менеджера я принес огромную пользу группе, за что был премирован. Все были мной довольны.";
                }
                else
                {
                    KakoiText.text += "Разве что пришел менеджер, которого я, на всякий случай, не пропустил. Больше ничего необычного.";
                }
                if (DontDestroy.pregant == true) KakoiText.text = "Прошлый день я польностью пропустил из-за произошедшей ситуации...";
                KakoiText.text += "\nСегодня группа отыгрывает последний день тура, концерт самый крупный из всех, это будет ой как непросто.";
                KakaiaCel.text = ""; //"Моя цель на сегодня:";
                break;
        }
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
                    MQNeVipolnen.text = "Собственное задание проваленно! \n Ты не смог накопить 25$!";
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
                    Yslovie = 1;
                    gameObject.GetComponent<Timer>().PanelSt();
                    gameObject.GetComponent<Timer>().Podschet();
                }
                break;
            case 131:
                Yslovie = 0;
                //gameObject.GetComponent<Timer>().PanelSt();
                Timer.provDen += 1;
                Timer.Den += 1;
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
