using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutor : MonoBehaviour
{

    public GameObject[] pop1;
    public GameObject Hit;
    public GameObject Jump;
    public GameObject Repair;
    public GameObject Charger;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D Other2)
    {
        if (Other2.tag == "Charger")
        {
            pop1[1].SetActive(true);
            Destroy(pop1[1], 1);
            Destroy(Charger);

        }        
        else
        if (Other2.tag == "Hit")
        {
            pop1[2].SetActive(true);
            Destroy(pop1[2], 1);
            Destroy(Hit);
        }
        else
        if (Other2.tag == "Jumper")
        {
            pop1[3].SetActive(true);
            Destroy(pop1[3], 1);
            Destroy(Jump);
        }
        else
        if (Other2.tag == "Repair")
        {
            pop1[4].SetActive(true);
            Destroy(pop1[4], 1);
            Destroy(Repair);
        }
        else       
        if (Other2.tag == "Lock")
        {
            pop1[5].SetActive(true);
           
        }
        else
        if (Other2.tag == "Unlock")
        {
            pop1[6].SetActive(true);
            Destroy(pop1[6], 1);
        }

    }
    void OnTriggerExit2D(Collider2D Other2)
    {
        if (Other2.tag == "Lock")
        {
            pop1[5].SetActive(false);
        }
    }
      
    
    
}
