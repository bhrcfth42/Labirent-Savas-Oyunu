using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZamanSayaci : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        OyuncuBilgieri.oynananZaman += Time.deltaTime;
    }
}
