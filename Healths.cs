using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healths : MonoBehaviour {

	public const int maxHealth = 100;

	public bool destroyOnDeath;

	public int currentHealth = maxHealth;

	public RectTransform healthBar;


	void Start (){
	}

		
	public void TakeDamage(int amount)
	{
		currentHealth -= amount;
		if (currentHealth <= 0) 
		{
			if (destroyOnDeath) 
			{

				Destroy (gameObject);
			}
		}
	}

	void OnChangeHealth (int currentHealth)
	{
		healthBar.sizeDelta = new Vector2 (currentHealth, healthBar.sizeDelta.y);
	}
}