using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repare_Car : MonoBehaviour
{
    public GameObject broken;
    public GameObject repared;
    public bool InTrigger = false;
    public int С_KolMet;
    public int С_KolEnergy;
    int С_needEnerdy;
    int С_needMet;
    public int С_IsEnergy;
    public int С_IsMet;

    public GameObject TopDrop;
    public bool IsDrop = false;

    public AudioSource IsRepare;

    

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && InTrigger == true && Counter.coinAmount >= С_KolMet && С_needMet != С_IsMet)
        {

            Counter.coinAmount -= С_KolMet;
            С_needMet += С_KolMet;

        }    
        if (Input.GetKeyDown(KeyCode.E) && InTrigger == true && Energy.energyAmount >= С_KolEnergy)
            {
               
                Energy.energyAmount -= С_KolEnergy;
                С_needEnerdy += С_KolEnergy;
            
                
            }
        if (Input.GetKeyDown(KeyCode.E) && С_needMet == С_IsMet && С_needEnerdy == С_IsEnergy)
        {
            IsRepare.Play();
            IsDrop = true;
            broken.SetActive(false);
            repared.SetActive(true);


            GetComponent<Collider2D>().enabled = false;
            this.enabled = false;
        }
        if (IsDrop == true)
            {      
                TopDrop = Instantiate(TopDrop, new Vector3(transform.position.x, transform.position.y, 0f), Quaternion.identity) as GameObject;
                IsDrop = false;
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
