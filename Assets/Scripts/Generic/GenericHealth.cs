﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericHealth : MonoBehaviour
{
	public int health = 0;
	
	void takeDamage(int toDamage)
	{
		// Will always assume the damage is taken.
		// Works alongside GenericDamage.cs
		// and any script that can call the
		// "takeDamage" function.

		health -= toDamage;
		if (health <= 0 && this.gameObject != GameObject.FindWithTag("Player"))
		{
			//SFXController sfx = GetComponent<SFXController>();
			//sfx.PlayDeathSFX();

			// update score
			if (this.gameObject.tag != "Bullet")
				GameObject.FindWithTag("Score").SendMessage("update_score", 10);

			Destroy(gameObject);
		}
	}
}
