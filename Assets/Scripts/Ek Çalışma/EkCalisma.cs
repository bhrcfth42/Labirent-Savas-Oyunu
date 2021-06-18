using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EkCalisma : MonoBehaviour
{
    public static float xPosition;
    public static Rect konum;
    bool sag;
    bool sol;
    bool showText;
    Color renk;
    // Start is called before the first frame update
    void Start()
    {
        sag = true;
        sol = false;
        showText = true;
        xPosition = 0;
        konum = new Rect(xPosition, 0, 300, 100);
        InvokeRepeating("Gosterme", 0, 1);
        InvokeRepeating("RenkDegisirme", 0, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (sag && xPosition >= 1570)
        {
            sol = !sol;
            sag = !sag;
        }
        else if (sol && xPosition <= 0)
        {
            sol = !sol;
            sag = !sag;
        }
        Kaydırma();
    }
    void Kaydırma()
    {
        if (sag)
        {
            xPosition++;
        }
        else if (sol)
        {
            xPosition--;
        }
    }
    void Gosterme()
    {
        showText = !showText;
    }
    void RenkDegisirme()
    {
        renk = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    }
    void OnGUI()
    {
        if (showText)
        {
            GUI.Window(3, new Rect(xPosition, 0, 350, 100), EkOzellik, "");
        }
        GUI.skin.label.fontSize = 30;
    }
    void EkOzellik(int WindowID)
    {
        GUI.color = renk;
        GUILayout.Label("Önder Fatih BUHURCU");
    }
}
