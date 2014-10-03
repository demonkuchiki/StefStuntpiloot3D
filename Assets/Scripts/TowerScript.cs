using UnityEngine;
using System.Collections;

public class TowerScript : MonoBehaviour {

	public GameObject arm;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0,-75 * Time.deltaTime,0);

		if(Input.GetKeyDown("space"))
		{
			arm.rigidbody.AddForce(transform.right * 100);
		}
	}
}
