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

    public GameObject TopDrop;
    public bool IsDrop = false;

    public AudioSource IsRepare;
	
	public GameObject arrow;
    public GameObject Low;
    int Metal, Energya;

    void Start()
    {
       Metal = this.GetComponent<Resurses>().needMet;
       Energya = this.GetComponent<Resurses>().needEnergy;
    }
    

    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.E) && InTrigger == true)
        {

            if (Counter.coinAmount > 0 && Metal > 0)
            {

                Counter.coinAmount -= KolMet;
                Metal -= KolMet;
            }


            if (Energy.energyAmount >= KolEnergy && Energya >= 0)
            {

                Energy.energyAmount -= KolEnergy;
                Energya -= KolEnergy;
            }
            else
            {
                Low.SetActive(true);
                Invoke("Lowoff", 0.5f);
            }


            if (Metal <= 0 && Energya <= 0)
            {
                IsRepare.Play();
                IsDrop = true;
                Destroy(broken);
                repared.SetActive(true);

                GetComponent<Collider2D>().enabled = false;
                this.enabled = false;
            }

        }
     
        

        if (IsDrop == true)
            {
                TopDrop = Instantiate(TopDrop, new Vector3(transform.position.x + 5f, transform.position.y), Quaternion.identity) as GameObject;
                IsDrop = false;
            }
           
                

    }
    void OnTriggerEnter2D(Collider2D Other2)
    {

        if (Other2.tag == "Player")
        {			
            InTrigger = true;
			arrow.SetActive(true);
        }       
    }
	void OnTriggerExit2D(Collider2D Other2)
    {

        if (Other2.tag == "Player")
        {		         
			arrow.SetActive(false);
            InTrigger = false;
        }        
    }
    void Lowoff()
    {
        Low.SetActive(false);
    }


}
