using UnityEngine;
using System.Collections;

public class Globals : MonoBehaviour {
	public Transform tipperBase;
	public Transform tipperAiBase;
	public Transform Tower;
	
	public arm ArmScript;

	public bool AiPush;
	public int playerPoints = 3;
	public int AiPoints = 3;

	public int playerPower = 1;
	public int AiPower = 1;

	void Start(){
		tipperBase = GameObject.Find("TipperBase").GetComponent<Transform>();
		tipperAiBase = GameObject.Find("TipperAiBase").GetComponent<Transform>();
		ArmScript = GameObject.Find("Arm").GetComponent<arm>();
	}
}
