using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repare : MonoBehaviour
{
    public GameObject broken;
    public GameObject repared;
    public bool InTrigger = false;
    public int KolMet;
    public int KolEnergy;
    int needEnerdy;
    int needMet;
    public int IsEnerdy;
    public int IsMet;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && InTrigger == true && Counter.coinAmount >= KolMet && needMet != IsMet)
        {
            Counter.coinAmount -= 10;
            needMet += 10;

        }
        if (Input.GetKeyDown(KeyCode.E) && InTrigger == true && Energy.energyAmount >= KolEnergy && needEnerdy != IsEnerdy)
        {
                Energy.energyAmount -= 15;
                needEnerdy += 15;
            if (needMet == 10 && needEnerdy == 300)
            {
                broken.SetActive(false);
                repared.SetActive(true);
                GetComponent<Collider2D>().enabled = false;
                this.enabled = false;
            }
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
