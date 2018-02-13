using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

private int count;
private Text countText;
private Text winText;


void start()
{
		count = 0;
	winText.text = " ";

	SetCountText();
}

void SetCountText()
{
	countText.text = "Coins: " + count.ToString();
	if(count==3)
	{
		winText.text = "You Win!";
	}
}
		

	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("Collectible"))
			{
			count = count + 1;
				other.gameObject.SetActive (false);
			SetCountText ();
		}
	}

}
