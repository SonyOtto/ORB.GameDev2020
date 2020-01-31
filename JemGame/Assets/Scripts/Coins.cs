using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
	
   void OnTriggerEnter2D(Collider2D Other2){
		if (Other2.tag == "Player"){			
			Counter.coinAmount +=1;
			Destroy (gameObject);
		}
		
	}
	
}
