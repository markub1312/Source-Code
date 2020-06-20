using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Make_Enemy : MonoBehaviour {
	public GameObject myPrefab = null;
	int en = 20;


	// Use this for initialization
	IEnumerator Start () {

		for (int i = 0; i < en;i++) {
			Instantiate (myPrefab, transform.position, Quaternion.identity);
			yield return new WaitForSeconds (1);

		}

	}
	
	// Update is called once per frame
	void Update () {



	}
}
