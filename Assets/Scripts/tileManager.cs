using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileManager : MonoBehaviour {

	public GameObject[]  tile_prefbabs;

	private Transform playerTransform;

	private float spawnZ = 0.0f;
	private float tile_Length = 200.0f;
	private int amountOFTilesOnScreen = 7;

	// Use this for initialization
	private void Start () {

		playerTransform = GameObject.FindGameObjectWithTag ("Player").transform;

		for (int i = 0; i < amountOFTilesOnScreen; i++) 
		{
			Spawn ();
		}
	}
	
	// Update is called once per frame
	private void Update () 
	{
		if (playerTransform.position.z > (spawnZ - amountOFTilesOnScreen * tile_Length)) 
		{
			Spawn ();
		}
	}

	private void Spawn(int prefabIndex = -1	)
	{
		GameObject go;
		go = Instantiate (tile_prefbabs [0]) as GameObject;
		go.transform.SetParent (transform);
		go.transform.position = Vector3.forward * spawnZ;

		spawnZ += tile_Length;
	}
}
