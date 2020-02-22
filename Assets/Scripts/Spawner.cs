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

    public static int ocheredforsujet = 0;

    void Start()
    {
        Clons();
    }

    public void Clons()
    {
        int modwho;
        modwho = UnityEngine.Random.Range(0, 8);
        string lname = SceneManager.GetActiveScene().name;
        if (ocheredforsujet == 1 && lname == "Story_Mode")
        {
            modwho = Story.PersForSujet;
            ocheredforsujet = 10;
        }
        if (modwho != zapomnil && modwho != zapomnil2)
        {
            zapomnil2 = zapomnil;
            zapomnil = modwho;

            ocheredforsujet += 1;

            switch (modwho)
            {
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

    //void spawnSAP4()
    //{
    //    whatToSpawnClone[3] = Instantiate(whatToSpawnPrefab[3], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    //}
}
