using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanKontrolu : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (OyuncuBilgieri.can <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Sahne_2");
        }
    }
}
