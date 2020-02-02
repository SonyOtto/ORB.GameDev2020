using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Special : MonoBehaviour
{
    public GameObject galochka_1;
    public GameObject galochka_2;
    public GameObject galochka_3;

    public GameObject old;
    public GameObject ended;

    bool chek1 = false;
    bool chek2 = false;
    bool chek3 = false;

    public bool allspecial = false;
    public bool incharge = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (chek1 == true && chek2 == true && chek3 == true)
        {
            allspecial = true;
        }
        if (Input.GetKeyDown(KeyCode.E) && allspecial == true && incharge == true )
        {
            old.SetActive(false);
            ended.SetActive(true);
            
        }
    }
    void OnTriggerEnter2D(Collider2D Other2)
    {
        if (Other2.tag == "Bottle")
        {
            galochka_1.SetActive(true);
            chek1 = true;
            Destroy(GameObject.FindGameObjectWithTag("Bottle"));
        }
        if (Other2.tag == "Shesternya")
        {
            galochka_2.SetActive(true);
            chek2 = true;
            Destroy(GameObject.FindGameObjectWithTag("Shesternya"));
        }
        if (Other2.tag == "Disketa")
        {
            galochka_3.SetActive(true);
            chek3 = true;
            Destroy(GameObject.FindGameObjectWithTag("Disketa"));
        }
        if (Other2.tag == "Charger_fix")
        {
            incharge = true;
        }
    }
    void OnTriggerExit2D(Collider2D Other2)
    {
       
        if (Other2.tag == "Charger_fix")
        {
            incharge = false;
        }
    }

}
