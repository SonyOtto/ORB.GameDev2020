using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repare : MonoBehaviour
{
    public GameObject broken;
    public GameObject repared;
    public bool InTrigger = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && InTrigger == true)
        {
            broken.SetActive(false);
            repared.SetActive(true);
            Energy.energyAmount -= 10;
            Counter.coinAmount -= 10;
            GetComponent<Collider2D>().enabled = false;
            this.enabled = false;
        }
    }
    void OnTriggerEnter2D(Collider2D Other2)
    {

        if (Other2.tag == "Player")
        {
            InTrigger = true;

        }
        else {
            InTrigger = false;
        }
    }
   
   
}
