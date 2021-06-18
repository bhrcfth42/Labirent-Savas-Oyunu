using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elmas : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            OyuncuBilgieri.puan += 50;
            OyuncuBilgieri.toplananElmas++;
            Destroy(gameObject);
        }
    }
}
