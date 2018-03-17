using System.Collections;
using UnityEngine;

public class GameOver : MonoBehaviour {

	private	void onCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "ball") 
		{
			Destroy (col.gameObject);
		}
	}

	private void OnTriggerEnter ( Collider other)
	{
		Destroy (other.gameObject);
	}
}
