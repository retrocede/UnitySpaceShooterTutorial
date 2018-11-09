﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {
    public GameObject explosion;
	public GameObject playerExplosion;
	void OnTriggerEnter(Collider other)
	{
		// being inside game bounds doesn't count
		if (other.CompareTag("Boundary"))
		{
			return;
		}

		Instantiate(explosion, transform.position, transform.rotation);
		if (other.CompareTag("Player"))
		{
			Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
		}
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}
