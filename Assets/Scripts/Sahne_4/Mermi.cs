using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mermi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        OyuncuBilgieri.mermiSayisi--;
        OyuncuBilgieri.harcananMermi++;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Düşman")
        {
            Destroy(other.gameObject);
            OyuncuBilgieri.oldurulenDusman++;
            Destroy(gameObject);
            OyuncuBilgieri.puan += 50;
        }
        else if (other.gameObject.tag == "Duvar")
        {
            Destroy(gameObject);
        }
    }
}
