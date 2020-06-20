using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	public float speed;
	public float distance;

	private bool movingRight = true;
	private bool movingUp = false;

	public Transform groundDetection;
	public Transform groundDetection2;
	public Transform groundDetection3;
	public Transform groundDetection4;
	public Transform target;







	void Update () {

		Vector2 dirMoving = new Vector2 (movingRight ? 1 : -1, movingUp ? 1 : -1);
		transform.Translate(dirMoving * speed * Time.deltaTime, Space.World);


		//transform.Translate (Vector2.right * speed * Time.deltaTime);
		Vector2 dirCheck = new Vector2 (1, 0);

		RaycastHit2D groundInfo = Physics2D.Raycast (groundDetection.position, dirCheck, distance);
		if (groundInfo.collider == false) {
			movingRight = !movingRight;
		}

		//transform.Translate (Vector2.right * speed * Time.deltaTime);
		Vector2 dirCheck4 = new Vector2 (-1, 0);

		RaycastHit2D groundInfo4 = Physics2D.Raycast (groundDetection4.position, dirCheck4, distance);
		if (groundInfo4.collider == false) {
			movingRight = !movingRight;
		}

		//transform.Translate (Vector2.up * speed * Time.deltaTime);
		Vector2 dirCheck2 = new Vector2 (0, 1);

		RaycastHit2D groundInfo2 = Physics2D.Raycast (groundDetection2.position, dirCheck2, distance);
		if (groundInfo2.collider == false) {
			movingUp = !movingUp;
		}

		Vector2 dirCheck3 = new Vector2 (0, -1);

		RaycastHit2D groundInfo3 = Physics2D.Raycast (groundDetection3.position, dirCheck3, distance);
		if (groundInfo3.collider == false) {
			movingUp = !movingUp;
		}
		/**/
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target.position, step);

		//Debug.DrawLine (groundDetection.position, groundDetection.position + (dirCheck * distance) ,Color.red);
	}
	GameObject enemy;

	void destroyenemy() {
		Destroy(enemy);
	}
}



	// Use this for initialization

	
	// Update is called once per frame

		