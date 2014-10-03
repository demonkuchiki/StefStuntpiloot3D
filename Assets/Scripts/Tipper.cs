using UnityEngine;
using System.Collections;

public class Tipper : MonoBehaviour {
	public Globals global;
	private int count;

	void Start () {
		global = GameObject.Find("GameManager").GetComponent<Globals>();
	}

	void Update () {
		if(global.tipperBase.transform.rotation.z >= 0 && Input.GetKeyDown("space"))
		{
			global.tipperBase.Rotate(0,0,-45);
			collider.enabled = true;
			count = 10;
		}

		if(global.tipperBase.transform.rotation.z <= 0)
		{
			global.tipperBase.Rotate(0,0,1);
		}

		if(count > 0)
			count -=1;
		else
			collider.enabled = false;
	}

	void OnTriggerEnter(Collider collision){
		if(collision.gameObject.tag == "Plane")
		{
			global.ArmScript.addForceToArm(global.playerPower);
		}

	}
}
