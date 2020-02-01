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
    public int IsEnergy;
    public int IsMet;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && InTrigger == true && Counter.coinAmount >= KolMet && needMet != IsMet)
        {
            Counter.coinAmount -= KolMet;
            needMet += KolMet;

        }
        if (Input.GetKeyDown(KeyCode.E) && InTrigger == true && Energy.energyAmount >= KolEnergy && needEnerdy != IsEnergy)
        {
                Energy.energyAmount -= KolEnergy;
                needEnerdy += KolEnergy;

            if (needMet == IsMet && needEnerdy == IsEnergy)
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
