using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D Other2)
    {
        if (Other2.tag == "Player" && Energy.energyAmount < 100)
        {
            Invoke("IsCharge", 3);
            
        }

    }
    void IsCharge()
    {
        Energy.energyAmount = 100;
    }
}
