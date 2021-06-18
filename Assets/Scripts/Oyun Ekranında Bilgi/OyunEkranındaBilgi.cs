using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunEkranındaBilgi : MonoBehaviour
{
    public GUISkin skin;
    void OnGUI()
    {
        GUI.skin = skin;
        GUILayout.Window(0, new Rect(0, 980, 300, 100), CanGUI, "");
        GUILayout.Window(1, new Rect(1620, 980, 300, 100), MermiGUI, "");
        GUILayout.Window(2, new Rect(810, 0, 300, 100), PuanGUI, "");
    }
    void CanGUI(int WindowID)
    {
        GUILayout.Label("HP: "+OyuncuBilgieri.can.ToString());
    }
    void MermiGUI(int WindowID)
    {
        GUILayout.Label("Mermi: "+OyuncuBilgieri.mermiSayisi.ToString());
    }
    void PuanGUI(int WindowID)
    {
        GUILayout.Label("Puan: "+OyuncuBilgieri.puan.ToString());
    }
}
