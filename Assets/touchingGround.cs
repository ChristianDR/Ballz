using UnityEngine;
using System.Collections;

public class touchingGround : MonoBehaviour {

	void onCollisonEnter(Collision col){

		if(col.gameObject.tag == "Jump Collider"){
		print ("hey");
		}
	}
}
