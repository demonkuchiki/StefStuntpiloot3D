using UnityEngine;
using System.Collections;

public class arm : MonoBehaviour {

	// Use this for initialization
	public void addForceToArm(){
		transform.rigidbody.AddForce(Vector3.up * 200);
	}
}
