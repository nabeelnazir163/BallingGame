using System.Collections;
using UnityEngine;

public class GameOver : MonoBehaviour {

	void onTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Bar") 
		{
			Application.LoadLevel ("MainMenu");
		}
	}
}
