using UnityEngine;
using System.Collections;

public class TowerScript : MonoBehaviour {
	void Start () {
	}

	void Update () {
		transform.Rotate(0,-75 * Time.deltaTime,0);
	}
}
