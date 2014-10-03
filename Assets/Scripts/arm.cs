using UnityEngine;
using System.Collections;

public class arm : MonoBehaviour {
	public Globals global;
	void Start (){
		global = GameObject.Find("GameManager").GetComponent<Globals>();
	}

	public void addForceToArm(int multiplier){
		transform.rigidbody.AddForce(Vector3.up *(200*multiplier));
	}
	void OnTriggerEnter(Collider collision){
		if(collision.gameObject.tag == "AiTrigger")
		{
			global.AiPush = true;
		}
	}
}
