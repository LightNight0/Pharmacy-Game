using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnLacations;
    public GameObject[] whatToSpawnPrefab;
    public GameObject[] whatToSpawnClone;

    int ocher = 1;
    int zapomnil = 100;
    int zapomnil2 = 100;
    int[] zapom = { 100, 100, 100, 100, 100, 100, 100, 100 };

    public static int ocheredforsujet = 0;

    void Start()
    {
        Clons();
    }

    public void Clons()
    {
        int modwho;
        modwho = UnityEngine.Random.Range(-6, 8);
        string lname = SceneManager.GetActiveScene().name;
        if (ocheredforsujet == 1 && lname == "Story_Mode")
        {
            modwho = Story.PersForSujet;
            ocheredforsujet = 10;
        }
        //if (modwho != zapomnil && modwho != zapomnil2)
        if (modwho != zapom[0] && modwho != zapom[1] && modwho != zapom[2] && modwho != zapom[3] && modwho != zapom[4] && modwho != zapom[5] && modwho != zapom[6])
        {
            //zapomnil2 = zapomnil;
            //zapomnil = modwho;

            zapom[6] = zapom[5];
            zapom[5] = zapom[4];
            zapom[4] = zapom[3];
            zapom[3] = zapom[2];
            zapom[2] = zapom[1];
            zapom[1] = zapom[0];
            zapom[0] = modwho;

            ocheredforsujet += 1;

            switch (modwho)
            {
                case -6:
                    spawnSAP14();
                    break;
                case -5:
                    spawnSAP13();
                    break;
                case -4:
                    spawnSAP12();
                    break;
                case -3:
                    spawnSAP11();
                    break;
                case -2:
                    spawnSAP10();
                    break;
                case -1:
                    spawnSAP9();
                    break;
                case 0:
                    spawnSAP();
                    break;
                case 1:
                    spawnSAP2();
                    break;
                case 2:
                    spawnSAP3();
                    break;
                case 3:
                    spawnSAP4();
                    break;
                case 4:
                    spawnSAP5();
                    break;
                case 5:
                    spawnSAP6();
                    break;
                case 6:
                    spawnSAP7();
                    break;
                case 7:
                    spawnSAP8();
                    break;
                case 8:
                    spawnSuj1(); // Репортерша
                    break;
                case 9:
                    spawnSuj2(); // Транс
                    break;
                case 10:
                    spawnSuj3(); // Наркоша
                    break;
                case 11:
                    spawnSuj4(); // Убермегафанатка
                    break;
                case 12:
                    spawnSuj5(); // Беременная
                    break;
                case 13:
                    spawnSuj6(); // Бизнес телка
                    break;
                case 22:
                    spawnSuj7(); // Наркоша 2
                    break;
            }
        }
        else Clons();
    }

    IEnumerator SIS()
    {
        yield return new WaitForSeconds(2.15f);
    }

    void spawnSAP()
    {
        whatToSpawnClone[0] = Instantiate(whatToSpawnPrefab[0], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    void spawnSAP2()
    {
        whatToSpawnClone[1] = Instantiate(whatToSpawnPrefab[1], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    void spawnSAP3()
    {
        whatToSpawnClone[2] = Instantiate(whatToSpawnPrefab[2], spawnLacations[1].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    void spawnSAP4()
    {
        whatToSpawnClone[3] = Instantiate(whatToSpawnPrefab[3], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    void spawnSAP5()
    {
        whatToSpawnClone[4] = Instantiate(whatToSpawnPrefab[4], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    void spawnSAP6()
    {
        whatToSpawnClone[5] = Instantiate(whatToSpawnPrefab[5], spawnLacations[2].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    void spawnSAP7()
    {
        whatToSpawnClone[6] = Instantiate(whatToSpawnPrefab[6], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    void spawnSAP8()
    {
        whatToSpawnClone[7] = Instantiate(whatToSpawnPrefab[7], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    void spawnSAP9()
    {
        string lname = SceneManager.GetActiveScene().name;
        if (lname == "Story_Mode") whatToSpawnClone[15] = Instantiate(whatToSpawnPrefab[15], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        if (lname == "Endless_Mode") whatToSpawnClone[8] = Instantiate(whatToSpawnPrefab[8], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    void spawnSAP10()
    {
        string lname = SceneManager.GetActiveScene().name;
        if (lname == "Story_Mode") whatToSpawnClone[16] = Instantiate(whatToSpawnPrefab[16], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        if (lname == "Endless_Mode") whatToSpawnClone[9] = Instantiate(whatToSpawnPrefab[9], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    void spawnSAP11()
    {
        string lname = SceneManager.GetActiveScene().name;
        if (lname == "Story_Mode") whatToSpawnClone[17] = Instantiate(whatToSpawnPrefab[17], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        if (lname == "Endless_Mode") whatToSpawnClone[10] = Instantiate(whatToSpawnPrefab[10], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    void spawnSAP12()
    {
        string lname = SceneManager.GetActiveScene().name;
        if (lname == "Story_Mode") whatToSpawnClone[18] = Instantiate(whatToSpawnPrefab[18], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        if (lname == "Endless_Mode") whatToSpawnClone[11] = Instantiate(whatToSpawnPrefab[11], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    void spawnSAP13()
    {
        string lname = SceneManager.GetActiveScene().name;
        if (lname == "Story_Mode") whatToSpawnClone[19] = Instantiate(whatToSpawnPrefab[19], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        if (lname == "Endless_Mode") whatToSpawnClone[12] = Instantiate(whatToSpawnPrefab[12], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    void spawnSAP14()
    {
        string lname = SceneManager.GetActiveScene().name;
        if (lname == "Story_Mode") whatToSpawnClone[20] = Instantiate(whatToSpawnPrefab[20], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        if (lname == "Endless_Mode") whatToSpawnClone[13] = Instantiate(whatToSpawnPrefab[13], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }
    // Для Сюжетки

    public void spawnSuj1() // Репортерша
    {
        whatToSpawnClone[8] = Instantiate(whatToSpawnPrefab[8], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    public void spawnSuj2() // Транс
    {
        whatToSpawnClone[9] = Instantiate(whatToSpawnPrefab[9], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    public void spawnSuj3() // Наркоша
    {
        whatToSpawnClone[10] = Instantiate(whatToSpawnPrefab[10], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    public void spawnSuj4() // Убермегафанатка
    {
        whatToSpawnClone[11] = Instantiate(whatToSpawnPrefab[11], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    public void spawnSuj5() // Беременная
    {
        whatToSpawnClone[12] = Instantiate(whatToSpawnPrefab[12], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    public void spawnSuj6() // Бизнес телка
    {
        whatToSpawnClone[13] = Instantiate(whatToSpawnPrefab[13], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    public void spawnSuj7() // Наркоша 2
    {
        whatToSpawnClone[14] = Instantiate(whatToSpawnPrefab[14], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    //void spawnSAP4()
    //{
    //    whatToSpawnClone[3] = Instantiate(whatToSpawnPrefab[3], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    //}
}
