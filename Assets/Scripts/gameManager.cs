using UnityEngine;
using System.Collections;

public class gameManager : MonoBehaviour {
	public Globals global;

	public GUIText AiPoints;
	public GUIText PlayerPoints;
	public GUIText Winlose;
	public GUIText PlayerPower;
	public GUIText AiPower;

	void Start (){
		global = GameObject.Find("GameManager").GetComponent<Globals>();
		Winlose.text = "";
		SetAiPointText();
		SetPlayerPointText();
		SetAiPowerText();
		SetPlayerPowerText();
	}

	void Update(){
		if(Input.GetKeyDown("w") && global.AiPower <3){
			global.AiPower ++;
			SetAiPowerText();
		}
		if(Input.GetKeyDown("s") && global.AiPower >1){
			global.AiPower --;
			SetAiPowerText();
		}
		if(Input.GetKeyDown("up") && global.playerPower <3){
			global.playerPower ++;
			SetPlayerPowerText();
		}
		if(Input.GetKeyDown("down") && global.playerPower >1){
			global.playerPower --;
			SetPlayerPowerText();
		}
	}

	public void SetPlayerPointText(){
		PlayerPoints.text = "Player Coins: " + global.playerPoints.ToString();
		if(global.playerPoints <= 0)
			Winlose.text = "You Lose!!!";
	}

	public void SetPlayerPowerText(){
		PlayerPower.text = "Players power: " + global.playerPower.ToString();
	}

	public void SetAiPointText(){
		AiPoints.text = "Player Coins: " + global.AiPoints.ToString();
		if(global.AiPoints <= 0)
			Winlose.text = "You Win!!!";
	}

	public void SetAiPowerText(){
		AiPower.text = "Ai difficulty: " + global.AiPower.ToString();
	}
}
