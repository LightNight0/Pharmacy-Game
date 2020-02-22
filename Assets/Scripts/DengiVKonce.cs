using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DengiVKonce : MonoBehaviour
{
    public static int skok = 0;
    public static int skokDa = 0;
    Text Deffki;
    Text Money;
    Text AllMoney;

    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.tag == "SD") Deffki = GetComponent<Text>();
        if (gameObject.tag == "SM") Money = GetComponent<Text>();
        if (gameObject.tag == "SAM") AllMoney = GetComponent<Text>();
        //добавить глобальную переменную и скрипт для хранеия данных 
    }

    // Update is called once per frame
    void Update()
    {
        //DontDestroy.Mon = skok * 25;
        //добавить глобальную переменную и скрипт для хранеия данных
        if (gameObject.tag == "SD") Deffki.text = "Запущенно Деффок: " + skok;
        if (gameObject.tag == "SM")
        {
            if (Move.skokrazoshibsa2 == 0) Money.text = "Кол-во Денег За День: " + ((skok * 25) + (skokDa * 25)) + "$";
            if (Move.skokrazoshibsa2 == 1) Money.text = "Кол-во Денег За День: " + ((skok * 25) + (skokDa * 25) - 5) + "$";
            if (Move.skokrazoshibsa2 == 2) Money.text = "Кол-во Денег За День: " + ((skok * 25) + (skokDa * 25) - 15) + "$";
            if (Move.skokrazoshibsa2 == 3) Money.text = "Кол-во Денег За День: " + ((skok * 25) + (skokDa * 25) - 30) + "$";
        }
        if (gameObject.tag == "SAM")
        {
            if (DontDestroy.Mon >= 0) AllMoney.text = "Кол-во Всех Денег: " + DontDestroy.Mon + "$";
            else AllMoney.text = "Долг: " + (DontDestroy.Mon * -1) + "$";
        }
    }
}
