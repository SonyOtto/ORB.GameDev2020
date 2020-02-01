using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDrop : MonoBehaviour
{
    public GameObject[] drop;
    

    // Start is called before the first frame update
    void Start()
    {
                 
            Instantiate(drop[100]);
        
    }


    
}
