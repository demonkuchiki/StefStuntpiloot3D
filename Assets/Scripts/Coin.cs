using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {
	public Globals global;
	public gameManager GameManager;

	public GameObject coin1;
	public GameObject coin2;

	private int count = 0;
	void Start(){
		global = GameObject.Find("GameManager").GetComponent<Globals>();
		GameManager = GameObject.Find("GameManager").GetComponent<gameManager>();
	}

	void Update () {
		transform.Rotate(new Vector3(15,30,45)*Time.deltaTime);
		if(count > 0 ){
			renderer.enabled = false;
			collider.enabled = false;
			count -= 1;
		}
		else if(count <=0 && global.playerPoints >0){
			renderer.enabled = true;
			collider.enabled = true;
		}
	}

	void OnTriggerEnter(Collider collision){
		if(collision.gameObject.tag == "Plane")
		{
			int temppoints = global.playerPoints;
			if(temppoints == global.playerPoints){
				global.playerPoints -= 1;
				GameManager.SetPlayerPointText();
				if(global.playerPoints == 2)
					coin2.renderer.enabled = false;
				else if(global.playerPoints == 1)
					coin1.renderer.enabled = false;
			}
			count = 30;
		}
		
	}
}
