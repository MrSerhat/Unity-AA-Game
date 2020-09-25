using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnaCember : MonoBehaviour
{
    public GameObject KucukCember;
    GameObject OyunYoneticisi;

    void Start()
    {
        OyunYoneticisi = GameObject.FindGameObjectWithTag("oyunyöneticisitag");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            KucukCemberOlustur();
        }
    }

    void KucukCemberOlustur()
    {
        Instantiate(KucukCember, transform.position, transform.rotation);
        OyunYoneticisi.GetComponent<OyunYonetici>().KucukCemberlerdeTextGosterme();
    }
}
