using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Koncovki : MonoBehaviour
{

    public Animator YourPath;
    public Text YourText;
    public Animator ReportPath;
    public Text ReportText;
    public Animator FanPath;
    public Text FanText;
    public Animator BusWPath;
    public Text BusWText;
    public Animator PregPath;
    public Text PregText;
    public GameObject Svet;
    public GameObject PregP;
    public Sprite[] spritesi = new Sprite[2];
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Sound>().SoundOn();
        gameObject.GetComponent<Sound>().KonecSong();
        StartCoroutine(SvetWait());
        YourSelf();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void YourSelf() //концовка ГГ завязанная на деньгах
    {
        if ((DontDestroy.Mon + DontDestroy.Lek) <= 0)
        {
            YourText.text = "Вы не смогли накопить средтсв на лечение, вы даже умудрились войти в долги, с такой жизнью вы долго не протяненте...\nМесяц или два...";
        }
        if ((DontDestroy.Mon + DontDestroy.Lek) < 500 && (DontDestroy.Mon + DontDestroy.Lek) > 0) 
        {
            YourText.text = "Жаль что по итогу этого путешествия денег оказалось так мало.\nНа эти деньги вы сможете посетить, перед смертью, то место, о котором всегда мечтали.";
        }
        if ((DontDestroy.Mon + DontDestroy.Lek) < 750 && (DontDestroy.Mon + DontDestroy.Lek) >= 500)
        {
            YourText.text = "Увы, если бы вы были более осторожным или предприимчевым, вы бы смогли собрать нужную сумму.\nЭтих денег не хватит на лечение, но вы сможете хорошо повеселится до прихода вашего конца, тем более, до него еще пару лет.";
        }
        if ((DontDestroy.Mon + DontDestroy.Lek) < 1000 && (DontDestroy.Mon + DontDestroy.Lek) >= 750)
        {
            YourText.text = "Вы были близко, но не смогли накопить на полную терапию, вы можете позволить себе лишь пару терапий, но не полный курс, впрочем, этого все равно хватит чтобы продлить жизнь на десятилетие.";
        }
        if ((DontDestroy.Mon + DontDestroy.Lek) < 1500 && (DontDestroy.Mon + DontDestroy.Lek) >= 1000)
        {
            YourText.text = "Сумму, которую вы собрали, хватит только на терапию, но без реабилитации.\nВам будет трудно справлятся первое время после терапии, но у вас все еще есть друзья, готовые вас поддержать и помочь вам.";
        }
        if ((DontDestroy.Mon + DontDestroy.Lek) >= 1500)
        {
            YourText.text = "Накопив нужную сумму, вы смогли полностью излечится от зависимости.\nТеперь вы снова можете беспокойно кататься по миру и веселится.";
        }

        StartCoroutine(YourWait());
    }

    void Reportersha()//концовка с группой и репортешей
    {
        if (DontDestroy.report2 == true) StartCoroutine(ReportWait());
        else UberFan();
    }

    void UberFan()//концовка про бассиста и убер мегафанатку
    {
        if (DontDestroy.uberfan == true) StartCoroutine(FanWait());
        else BusW();
    }

    void BusW()//концовка про менеджера с предложением
    {
        if (DontDestroy.busw == true) StartCoroutine(BuswWait());
        else Preg();
    }

    void Preg()//концовка про малого от вокалиста
    {
        if (DontDestroy.pregant == true)
        {
            PregP.GetComponent<Image>().sprite = spritesi[0];
            PregText.text = "Грустная история приключилась с девушкой, некогда бывшей фанаткой, которая носила под своим сердцем ребенка от любимого всеми певца.\nПосле пропажи её еще долго искали друзья и близкие, но тело так и не нашли...";
        }
        else
        {
            PregP.GetComponent<Image>().sprite = spritesi[1];
            PregText.text = "Но самое главное это то, что маленький мальчик с кудрявыми волосами и слегка глупой улыбкой из Детройта, так и никогда не узнает кто его настоящий отец.";
        }
        StartCoroutine(PregWait());
    }

    IEnumerator YourWait()
    {
        YourPath.enabled = true;
        bool ijHidden = YourPath.GetBool("isHidden");
        YourPath.SetBool("isHidden", !ijHidden);

        yield return new WaitForSeconds(10.0f);

        bool izHidden = YourPath.GetBool("isDa");
        YourPath.SetBool("isDa", !izHidden);

        yield return new WaitForSeconds(1.0f);
        Reportersha();
    }

    IEnumerator ReportWait()
    {
        ReportPath.enabled = true;
        bool ijHidden = ReportPath.GetBool("isHidden");
        ReportPath.SetBool("isHidden", !ijHidden);

        yield return new WaitForSeconds(10.0f);

        bool izHidden = ReportPath.GetBool("isDa");
        ReportPath.SetBool("isDa", !izHidden);

        yield return new WaitForSeconds(1.0f);
        UberFan();
    }

    IEnumerator FanWait()
    {
        FanPath.enabled = true;
        bool ijHidden = FanPath.GetBool("isHidden");
        FanPath.SetBool("isHidden", !ijHidden);

        yield return new WaitForSeconds(10.0f);

        bool izHidden = FanPath.GetBool("isDa");
        FanPath.SetBool("isDa", !izHidden);

        yield return new WaitForSeconds(1.0f);
        BusW();
    }

    IEnumerator BuswWait()
    {
        BusWPath.enabled = true;
        bool ijHidden = BusWPath.GetBool("isHidden");
        BusWPath.SetBool("isHidden", !ijHidden);

        yield return new WaitForSeconds(10.0f);

        bool izHidden = BusWPath.GetBool("isDa");
        BusWPath.SetBool("isDa", !izHidden);

        yield return new WaitForSeconds(1.0f);
        Preg();
    }

    IEnumerator PregWait()
    {
        PregPath.enabled = true;
        bool ijHidden = PregPath.GetBool("isHidden");
        PregPath.SetBool("isHidden", !ijHidden);

        yield return new WaitForSeconds(10.0f);

        bool izHidden = PregPath.GetBool("isDa");
        PregPath.SetBool("isDa", !izHidden);

        yield return new WaitForSeconds(1.5f);
        gameObject.GetComponent<Sound>().TitriSong();
        SceneManager.LoadScene("Titri");
    }

    IEnumerator SvetWait()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.05f);
            Svet.SetActive(false);
            yield return new WaitForSeconds(0.05f);
            Svet.SetActive(true);
        }
    }

}
