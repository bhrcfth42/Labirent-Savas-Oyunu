using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuAtes : MonoBehaviour
{
    public Transform mermininCikisNoktasi;
    public GameObject mermi;
    [SerializeField] bool atacked;
    [SerializeField] float currenAtackTimer;
    [SerializeField] float defautAtackTimer;
    // Start is called before the first frame update
    void Start()
    {
        atacked = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!atacked && OyuncuBilgieri.mermiSayisi > 0)
            {
                atacked = true;
                AtesEtme();
            }

        }
        if (atacked)
        {
            currenAtackTimer -= Time.deltaTime;
        }
        else
        {
            currenAtackTimer = defautAtackTimer;
        }
        if (currenAtackTimer <= 0)
        {
            atacked = false;
        }
    }

    void AtesEtme()
    {
        GameObject mermimiz = Instantiate(mermi, mermininCikisNoktasi.position, mermininCikisNoktasi.rotation) as GameObject;
        mermimiz.GetComponent<Rigidbody>().velocity = transform.forward * 15;
    }
}
