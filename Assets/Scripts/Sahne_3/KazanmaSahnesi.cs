using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KazanmaSahnesi : MonoBehaviour
{
    public GUISkin skin;
    public Texture logo;
    void OnGUI()
    {
        GUI.skin = skin;
        GUILayout.Window(0, new Rect(0, 0, 1920, 1080), OyunGUI, "");
    }
    void OyunGUI(int WindowID)
    {
        GUILayout.Box(logo, GUILayout.MaxHeight(175));
        GUILayout.Label("KAZANDINIZ");
        GUILayout.Label(OyuncuBilgieri.oyuncuAdi);
        GUILayout.BeginHorizontal("box");
        GUILayout.Label("Puanınız :");
        GUILayout.Label(OyuncuBilgieri.puan.ToString());
        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal("box");
        GUILayout.Label("Öldürülen Düşman Sayısı :");
        GUILayout.Label(OyuncuBilgieri.oldurulenDusman.ToString());
        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal("box");
        GUILayout.Label("Toplanan Elmas Sayısı :");
        GUILayout.Label(OyuncuBilgieri.toplananElmas.ToString());
        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal("box");
        GUILayout.Label("Toplanan Can Sayısı :");
        GUILayout.Label(OyuncuBilgieri.toplananCan.ToString());
        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal("box");
        GUILayout.Label("Toplanan Mermi Sayısı :");
        GUILayout.Label(OyuncuBilgieri.toplananMermi.ToString());
        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal("box");
        GUILayout.Label("Harcanan Mermi Sayısı :");
        GUILayout.Label(OyuncuBilgieri.harcananMermi.ToString());
        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal("box");
        GUILayout.Label("Oynanan Süre :");
        GUILayout.Label(OyuncuBilgieri.oynananZaman.ToString());
        GUILayout.EndHorizontal();
        
        if (GUILayout.Button("Çıkış"))
        {
            Application.Quit();
        }
    }
}
