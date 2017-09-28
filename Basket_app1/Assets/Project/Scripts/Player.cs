using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public Ball ball;
	public GameObject playerCamara;
	public float ballDistance = 2f;
	public float ballThrowingForce = 5f;


	public bool holdingBall = true;


	// Use this for initialization
	void Start () {
		ball.GetComponent<Rigidbody>().useGravity = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(holdingBall){
			ball.transform.position = playerCamara.transform.position + playerCamara.transform.forward * ballDistance;

			//clic mouse

			if(Input.GetMouseButtonDown(0)){
				holdingBall = false;
				ball.ActivateTrail ();
				ball.GetComponent<Rigidbody>().useGravity = true;
				ball.GetComponent<Rigidbody>().AddForce(playerCamara.transform.forward * ballThrowingForce);

			}


		}
		
	}
}
