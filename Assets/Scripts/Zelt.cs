using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zelt : Objects
{

    public GameObject Mainlight;
    public GameObject Tentlight1;
    public GameObject Tentlight2;

    // Start is called before the first frame update
    void Start()
    {   /*
        Mainlight = GameObject.Find("Directional Light");
        Tentlight1 = GameObject.Find("Point Light");
        Tentlight2 = GameObject.Find("Spot Light");
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void DoOnClick()
    {
        Mainlight.transform.Rotate(Vector3.down * 180);
        if (Tentlight1.activeSelf == true)
        {
            Tentlight1.SetActive(false);
            Tentlight2.SetActive(false);
        }
        else
        {
            Tentlight1.SetActive(true);
            Tentlight2.SetActive(true);
        }
    }
}
