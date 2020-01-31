using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //public Animator animator;
    public GameObject drop;
    public GameObject TopDrop;
    public int maxHealth = 100;
	int currentHealth;

    // Update is called once per frame
    void Start()
    {
        currentHealth = maxHealth;
    }
	
	public void TakeDamage(int damage)
	{
		currentHealth -= damage;
		
		//animator.SetTrigger("Hurt");
		
		
		if (currentHealth <= 0)
		{
			Die();
		}
	}
	
	void Die()
	{
        //animator.SetBool("IsDead", true);
        Destroy(gameObject);       
        drop = Instantiate(drop, new Vector3(transform.position.x, transform.position.y+0.1f, 0f), Quaternion.identity) as GameObject;
        drop = Instantiate(drop, new Vector3(transform.position.x, transform.position.y+0.2f, 0f), Quaternion.identity) as GameObject;
        TopDrop = Instantiate(TopDrop, new Vector3(transform.position.x + 1.0f, transform.position.y - 0.0f, -1.2f), Quaternion.identity) as GameObject;
    }
}
