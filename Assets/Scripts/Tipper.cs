using UnityEngine;
using System.Collections;

public class Tipper : MonoBehaviour {

	public Transform tipperBase;
	public Transform Tower;
	private arm ArmScript;
	private int count;
	// Use this for initialization
	void Start () {
		tipperBase = transform.FindChild("TipperBase");
		ArmScript = GameObject.Find("Arm").GetComponent<arm>();
	}
	
	// Update is called once per frame
	void Update () {
		if(tipperBase.transform.rotation.z >= 0 && Input.GetKeyDown("space"))
		{
			tipperBase.Rotate(0,0,-45);
			collider.enabled = true;
			count = 10;
		}

		if(tipperBase.transform.rotation.z <= 0)
		{
			tipperBase.Rotate(0,0,1);
		}

		if(count > 0)
			count -=1;
		else
			collider.enabled = false;
	}

	void OnTriggerEnter(Collider collision){
		if(collision.gameObject.tag == "Plane")
		{
			Debug.Log("ello");
			ArmScript.addForceToArm();
		}

	}
}
