using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    public GameObject Light_player;
    public GameObject Wall;
    void Update()
    {
        Light_player.SetActive(false);
        Wall.SetActive(false);
        
    }
}
