using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDen : MonoBehaviour
{

    public Text Rashodi;
    public Text OstatoDeneg;
    public Text PerHP;
    public Text PerZV;
    public Text OtlDen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OtlDen.text = "Отложить Все На Лекарство: " + (DontDestroy.Lek + Timer.Lekabuff) + "/1500$"; 
        PerHP.text = Timer.zavotdeneg1 + "%";
        PerZV.text = Timer.zavotdeneg2 + "%";
        Rashodi.text = "Ежедневные Расходы: " + (Timer.zavotdeneg + 10) + "$";
        if (DontDestroy.Mon >= 0) OstatoDeneg.text = "Оставшиеся Деньги: " + DontDestroy.Mon + "$";
        else OstatoDeneg.text = "Вы в долгах: " + (DontDestroy.Mon * -1) + "$";
    }
}
