using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MermiArtirici : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            OyuncuBilgieri.mermiSayisi+=3;
            OyuncuBilgieri.toplananMermi++;
            Destroy(gameObject);
        }
    }
}
