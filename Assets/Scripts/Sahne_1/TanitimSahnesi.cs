using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TanitimSahnesi : MonoBehaviour
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
        GUILayout.Box(logo);
        GUILayout.Label(TanıtımBilgileri.oyunAdi);
        GUILayout.Label(TanıtımBilgileri.ogrAd+" "+TanıtımBilgileri.ogrSoyad);
        GUILayout.Label(TanıtımBilgileri.ogrOkulNo);
        GUILayout.Label("Oyuncu Adınızı Giriniz :");
        OyuncuBilgieri.oyuncuAdi = GUILayout.TextField(OyuncuBilgieri.oyuncuAdi);
        if(GUILayout.Button("Başla")&&OyuncuBilgieri.oyuncuAdi!=null){
            SceneManager.LoadScene("Sahne_4");
        }
    }
}
