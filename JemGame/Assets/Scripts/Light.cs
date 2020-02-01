using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    public GameObject Light_player;   
  
    void Update()
    {
        Light_player.SetActive(false);
        
    }
}
