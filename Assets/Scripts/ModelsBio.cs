using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelsBio : MonoBehaviour
{

    public static string TypeM;
    GameObject Who;
    public int stat = 0;

    //public static string charectirt1;
    //public static string charectirt2;
    //public static string charectirt3;

    public static int charectirt1 = 0;
    public static int charectirt2 = 0;
    public static int charectirt3 = 0;

    public static int charectirtO1 = 0;
    public static int charectirtO2 = 0;
    public static int charectirtO3 = 0;

    public static string[] fan = new string[9] { "Еще какая! Микки мой любимый член группы!", "А что за группа?", "Я купила все их 4 альбома", "Конечно, всех 3 ребят знаю лично", "Это мой первый концерт, но я их очень люблю", "Самая Большая", "А по мне не видно?", "Самая большая фанатка в мире, люблю их досмерти", "Мне нет до них дела" };
    public static string[] ves = new string[9] { "LCD-TV", "PlanB", "Kokos", "Фотокамера", "Контрацептивы", "Подвох", "Подвох и Ствол", "Пузожитель", "Куча бумаг и документов" };
    public static string[] old = new string[3] { "Я уже совсем взрослая, мне: ", "Такое неприлично спрашивать, но раз это важно: ", "Уже можно: " };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewM()
    {
        Who = GameObject.FindWithTag("Model");
        if (Who.name == "DarkHair1(Clone)" || Who.name == "DarkHair2(Clone)" || Who.name == "DarkHair3(Clone)" || Who.name == "DarkHair4(Clone)")
        {
            TypeM = "DarkHair";
            Move.podhodit1 = 2;
            stat = 1;
            Hz();
        }
        if (Who.name == "RedHair1(Clone)" || Who.name == "RedHair2(Clone)" || Who.name == "RedHair3(Clone)" || Who.name == "RedHair4(Clone)")
        {
            TypeM = "RedHair";
            Move.podhodit1 = 3;
            stat = 2;
            Hz();
        }
        if (Who.name == "BlondHair1(Clone)" || Who.name == "BlondHair2(Clone)" || Who.name == "BlondHair3(Clone)" || Who.name == "BlondHair4(Clone)")
        {
            TypeM = "BlondHair";
            Move.podhodit1 = 1;
            stat = 3;
            Hz();
        }
        if (Who.name == "Trans1(Clone)" || Who.name == "Trans2(Clone)")
        {
            TypeM = "Ne";
            Move.podhodit1 = 42;
            stat = 4;
            Hz();
        }
        // Для Сюжетки
        if (Who.name == "TransB(Clone)")
        {
            TypeM = "Ne";
            Move.podhodit1 = 42;
            stat = 5;
            Hz();
        }
        if (Who.name == "Ber(Clone)")
        {
            TypeM = "DarkHair";
            Move.podhodit1 = 2; // 
            stat = 6;
            Hz();
        }
        if (Who.name == "BW(Clone)")
        {
            TypeM = "RedHair";
            Move.podhodit1 = 3; // 
            stat = 7;
            Hz();
        }
        if (Who.name == "Nark(Clone)")
        {
            TypeM = "DarkHair";
            Move.podhodit1 = 2; // 
            stat = 8;
            Hz();
        }
        if (Who.name == "Rep(Clone)")
        {
            TypeM = "DarkHair";
            Move.podhodit1 = 2; // 
            stat = 9;
            Hz();
        }
        if (Who.name == "TryFan(Clone)")
        {
            TypeM = "BlondHair";
            Move.podhodit1 = 1; // 
            stat = 10;
            Hz();
        }
        if (Who.name == "Nark2(Clone)")
        {
            TypeM = "BlondHair";
            Move.podhodit1 = 2; // 
            stat = 11;
            Hz();
        }
    }

    void Hz()
    {
        switch (stat)
        {
            case 1:
                RandomizerChar1(); //проверка на фана
                RandomizerChar2(); //проверка на стафф
                RandomizerChar3(); //проверка на совершенолетие

                break;
            case 2:
                RandomizerChar1(); //проверка на фана
                RandomizerChar2(); //проверка на стафф
                RandomizerChar3(); //проверка на совершенолетие

                break;
            case 3:
                RandomizerChar1(); //проверка на фана
                RandomizerChar2(); //проверка на стафф
                RandomizerChar3(); //проверка на совершенолетие
                
                break;
            case 4:
                RandomizerChar1(); //проверка на фана
                charectirtO2 = 6; //RandomizerChar2(); //проверка на стафф
                int firstchar;
                firstchar = Random.Range(20, 29);
                charectirtO3 = firstchar; //RandomizerChar3(); //проверка на совершенолетие

                break;
            //Для Сюжетки
            case 5: //Транс
                charectirt1 = 5;
                charectirtO1 = 1;

                charectirt2 = 6;
                charectirtO2 = 7;

                charectirt3 = 1;
                charectirtO3 = 23;
                break;
            case 6: // Беременная
                charectirt1 = 6;
                charectirtO1 = 1;

                charectirt2 = 7;
                charectirtO2 = 8;

                charectirt3 = 1;
                charectirtO3 = 25;
                break;
            case 7: // Бизнес телка
                charectirt1 = 8;
                charectirtO1 = 2;

                charectirt2 = 8;
                charectirtO2 = 9;

                charectirt3 = 1;
                charectirtO3 = 28;
                break;
            case 8: // Нарко телка
                charectirt1 = 8;
                charectirtO1 = 2;

                charectirt2 = 1;
                charectirtO2 = 2;

                charectirt3 = 2;
                charectirtO3 = 22;
                break;
            case 9: // Репортерша
                charectirt1 = 0;
                charectirtO1 = 1;

                charectirt2 = 3;
                charectirtO2 = 4;

                charectirt3 = 2;
                charectirtO3 = 20;
                break;
            case 10: // Убермегафанатка
                charectirt1 = 7;
                charectirtO1 = 1;

                charectirt2 = 4;
                charectirtO2 = 5;

                charectirt3 = 0;
                charectirtO3 = 17;
                break;
            case 11: // Нарко 2
                charectirt1 = 1;
                charectirtO1 = 2;

                charectirt2 = 0;
                charectirtO2 = 1;

                charectirt3 = 2;
                charectirtO3 = 22;
                break;
        }
        stat = 0;
    }

    void RandomizerChar1()
    {
        int firstchar;
        //string[] strArr = new string[5] { "Еще какая!, Микки мой любимый член группы!", "А что за группа ?", "Я купила все их 4 альбома", "Конечно, всех 3 ребят зняю лично", "Это мой первый концерт, но я их очень люблю" };
        firstchar = Random.Range(0, 5);
        charectirt1 = firstchar;
        if (firstchar == 0 || firstchar == 2 || firstchar == 4)
        {
            charectirtO1 = 1;
        }
        if (firstchar == 1 || firstchar == 3)
        {
            charectirtO1 = 2;
        }
    }

    void RandomizerChar2()
    {
        int firstchar;
        //string[] strArr = new string[5] { "LCD-TV", "PlanB", "Kokos", "Фотокамера", "Контрацептивы" };
        firstchar = Random.Range(0, 5);
        charectirt2 = firstchar;
        //if (firstchar > 2) charectirtO2 = 1;
        if (firstchar == 0) charectirtO2 = 1; // "LCD-TV"
        if (firstchar == 1) charectirtO2 = 2; // "PlanB"
        if (firstchar == 2) charectirtO2 = 3; // "Kokos"

        if (firstchar == 3) charectirtO2 = 4; // Камера
        if (firstchar == 4) charectirtO2 = 5;
    }

    void RandomizerChar3()
    {
        int firstchar;
        firstchar = Random.Range(15, 29);
        charectirtO3 = firstchar;
        //string[] strArr = new string[3] { "Я уже совсем взрослая, мне: ", "Такое неприлично спрашивать, но раз это важно: ", "Уже можно: " };
        firstchar = Random.Range(0, 3);
        charectirt3 = firstchar;
    }

}
