using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repare_Light : MonoBehaviour
{
    public GameObject broken;
    public GameObject repared;
    public bool InTrigger = false;
    public int L_KolMet;
    public int L_KolEnergy;
    int L_needEnerdy;
    int L_needMet;
    public int L_IsEnergy;
    public int L_IsMet;

    public GameObject TopDrop;
    public bool IsDrop = false;

    public AudioSource IsRepare;

    

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && InTrigger == true && Counter.coinAmount >= L_KolMet && L_needMet != L_IsMet)
        {

            Counter.coinAmount -= L_KolMet;
            L_needMet += L_KolMet;

        }    
        if (Input.GetKeyDown(KeyCode.E) && InTrigger == true && Energy.energyAmount >= L_KolEnergy)
            {
               
                Energy.energyAmount -= L_KolEnergy;
                L_needEnerdy += L_KolEnergy;
            
                
            }
        if (Input.GetKeyDown(KeyCode.E) && L_needMet == L_IsMet && L_needEnerdy == L_IsEnergy)
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
