using UnityEngine;
using System.Collections;

public class JumpingToMusicScript : MonoBehaviour {

	public AudioAnalyzing lyd;

	public int jumpPower;
	public int movementSpeed;
	private bool grounded;

	// Use this for initialization
	void Start () {
	
		grounded = false;
		rigidbody.velocity = Vector3.up*(100);
	//rigidbody.useGravity = Vector3 (0,0,0);

		//Physics.gravity = Vector3.down*20;


	}
	
	// Update is called once per frame
	void Update () {
	


		if (lyd.pitchValue > 400 ) {

//			rigidbody.velocity();
			rigidbody.AddForce(Vector3.up*jumpPower);

				}

	}

	void onCollisionEnter(Collision col){

		if(col.gameObject.tag == "Jump Collider"){
		
		print ("hej");

		}
	}


}
