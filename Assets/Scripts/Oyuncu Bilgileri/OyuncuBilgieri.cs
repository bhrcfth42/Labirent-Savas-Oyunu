using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyuncuBilgieri : MonoBehaviour
{
    public static string oyuncuAdi;
    public static int can = 100;
    public static int puan = 0;
    public static int oldurulenDusman = 0;
    public static int toplananElmas = 0;
    public static int mermiSayisi = 10;
    public static int harcananMermi = 0;
    public static int toplananCan = 0;
    public static int toplananMermi = 0;
    public static float oynananZaman = 0;
    private void Update()
    {
        if (can <= 0)
        {
            SceneManager.LoadScene("Sahne_2");
        }
    }
}
