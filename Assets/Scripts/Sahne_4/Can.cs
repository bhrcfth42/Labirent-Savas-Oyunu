using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Can : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if ((OyuncuBilgieri.can + 10) >= 100)
            {
                OyuncuBilgieri.can = 100;
            }
            else
            {
                OyuncuBilgieri.can += 10;
            }
            OyuncuBilgieri.toplananCan++;
            Destroy(gameObject);
        }
    }
}
