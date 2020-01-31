using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Energy : MonoBehaviour
{
    public static int energyAmount = 100;
    int i;
    Text text;
    
    // Start is called before the first frame update
    void Start()
    {     
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
             
        text.text = energyAmount.ToString();
    }

   
}
