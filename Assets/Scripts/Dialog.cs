﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    public Text DialogB;
    int drop = 0;
    int otv = 0;

    int zapomnil = 100;
    int zapomnil2 = 100;

    GameObject pers;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Move.aga == 1 && drop == 0)
        {
            Frazi();
            //
            pers = GameObject.FindWithTag("Model");
            if (pers.name == "Ber(Clone)")
            {
                var color = DialogB.color;
                color.r = 0.7f;
                color.g = 0.0f;
                color.b = 1.0f;
                DialogB.color = color;
                DialogB.text = "Пропусти меня, мне нужно встретится с отцом моего ребенка, он вокалист в группе!";
            }
            if (pers.name == "BW(Clone)")
            {
                var color = DialogB.color;
                color.r = 0.7f;
                color.g = 0.0f;
                color.b = 1.0f;
                DialogB.color = color;
                DialogB.text = "Я представитель компании \"SexyMyzTorg\", у меня есть деловое предложение к группе, пропусти.";
            }
            if (pers.name == "Nark(Clone)")
            {
                var color = DialogB.color;
                color.r = 0.7f;
                color.g = 0.0f;
                color.b = 1.0f;
                DialogB.color = color;
                DialogB.text = "Привет, слушай, можешь занять мне 250$?\n Я обязательно верну как-нибудь!";
                if (DontDestroy.nark == true) DialogB.text = "Привет, ты меня сильно выручил, вот и я в долгу не остнусь.\nВижу тебе не очень хорошо, держи, это поможет.";
            }
            if (pers.name == "Rep(Clone)")
            {
                var color = DialogB.color;
                color.r = 0.7f;
                color.g = 0.0f;
                color.b = 1.0f;
                DialogB.color = color;
                DialogB.text = "А, привет, пропусти пожалуйста, я дам тебе 500$.";
                if (DontDestroy.report1 == false && Timer.provDen == 11) DialogB.text = "Снова привет, пропусти пожалуйста, я дам тебе 750$.";
            }
            if (pers.name == "TransB(Clone)")
            {
                var color = DialogB.color;
                color.r = 0.7f;
                color.g = 0.0f;
                color.b = 1.0f;
                DialogB.color = color;
                DialogB.text = "Даров, пропусти к ним, будь так добр, или тебе не поздоровится.";
            }
            if (pers.name == "TryFan(Clone)")
            {
                var color = DialogB.color;
                color.r = 0.7f;
                color.g = 0.0f;
                color.b = 1.0f;
                DialogB.color = color;
                DialogB.text = "Я самая преданная фанатка, пропусти пожалуйста, я точно им понравлюсь. Я очень сильно хочу их увидеть!";
            }
            if (pers.name == "Nark2(Clone)")
            {
                var color = DialogB.color;
                color.r = 0.7f;
                color.g = 0.0f;
                color.b = 1.0f;
                DialogB.color = color;
                DialogB.text = "Слушай, ты какой-то слишком напряженный, прими это - расслабься.\nНу как, теперь пропустишь меня?";
            }
            drop = 1;
        }
        if (Move.aga == 2)
        {
            var color = DialogB.color;
            color.r = 0.0f;
            color.g = 0.0f;
            color.b = 0.0f;
            DialogB.color = color;
            DialogB.text = "Спасибо";
            drop = 0;
            if (otv == 2 && pers.name != "Nark(Clone)" && pers.name != "Rep(Clone)")
            {
                DontDestroy.Mon += 25;
                DengiVKonce.skokDa += 1;
                otv = 0;
            }
            if (pers.name == "Rep(Clone)")
            {
                if (DontDestroy.report1 == false && Timer.provDen == 11) DontDestroy.Mon += 750;
                else DontDestroy.Mon += 500;
                pers.name = "Pshel";
            }
        }
        if (Move.aga == 3)
        {
            var color = DialogB.color;
            color.r = 0.0f;
            color.b = 0.0f;
            color.g = 0.0f;
            DialogB.color = color;
            DialogB.text = "Да пошёл ты!";
            drop = 0;
        }
        if (Move.aga == 104)
        {
            var color = DialogB.color;
            color.r = 0.7f;
            color.g = 0.0f;
            color.b = 1.0f;
            DialogB.color = color;
            DialogB.text = "Привет, ты меня сильно выручил, вот и я в долгу не остнусь.\nВижу тебе не очень хорошо, держи, это поможет.";
        }
    }

    void Frazi()
    {
        int otvet = 0;
        string[] strArr = new string[5] { "Пусти плиз.", "Я очень сильно хочу туда попасть.", "Я дам тебе 25$, если пропустишь.", "Пропусти меня, они знают кто я такая.", "Я самая преданная фанатка, пропусти меня к ним." };
        otvet = Random.Range(0, 4);
        if (otvet != zapomnil && otvet != zapomnil2)
        {
            zapomnil2 = zapomnil;
            zapomnil = otvet;

            DialogB.text = strArr[otvet];
            otv = otvet;

            if (otvet == 2)
            {
                var color = DialogB.color;
                color.r = 0.0f;
                color.b = 0.0f;
                color.g = 0.5f;
                DialogB.color = color;
            }
            else
            {
                var color = DialogB.color;
                color.r = 0.0f;
                color.b = 0.0f;
                color.g = 0.0f;
                DialogB.color = color;
            }
        }
        else Frazi();
    }

    public void UFan()
    {
        var color = DialogB.color;
        color.r = 0.0f;
        color.g = 0.0f;
        color.b = 0.0f;
        DialogB.color = color;
        DialogB.text = ModelsBio.fan[ModelsBio.charectirt1];
    }

    public void Dosmotrr()
    {
        var color = DialogB.color;
        color.r = 0.0f;
        color.g = 0.0f;
        color.b = 0.0f;
        DialogB.color = color;
        DialogB.text = "<Вы Нашли: " + ModelsBio.ves[ModelsBio.charectirtO2 - 1] + ">";
    }

    public void HowOld()
    {
        var color = DialogB.color;
        color.r = 0.0f;
        color.g = 0.0f;
        color.b = 0.0f;
        DialogB.color = color;
        DialogB.text = ModelsBio.old[ModelsBio.charectirt3] + ModelsBio.charectirtO3;
    }

}
