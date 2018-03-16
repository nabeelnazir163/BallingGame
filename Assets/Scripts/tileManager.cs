using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileManager : MonoBehaviour {

	public GameObject[]  tile_prefbabs;

	private Transform playerTransform;

	private float spawnZ = 0.0f;
	private float tile_Length = 200.0f;
	private int amountOFTilesOnScreen = 3;

	private float safeZone = 350.0f;

	private List<GameObject> activeTiles;

	// Use this for initialization
	private void Start () {

		activeTiles = new List<GameObject>();

		playerTransform = GameObject.FindGameObjectWithTag ("Model").transform;

		for (int i = 0; i < amountOFTilesOnScreen; i++) 
		{
			Spawn ();
		}
	}
	
	// Update is called once per frame
	private void Update () 
	{
		if (playerTransform.position.z - safeZone> (spawnZ - amountOFTilesOnScreen * tile_Length)) 
		{
			Spawn ();
			DeleteTiles ();
		}
	}

	private void Spawn(int prefabIndex = -1	)
	{
		GameObject go;
		go = Instantiate (tile_prefbabs [0]) as GameObject;
		go.transform.SetParent (transform);
		go.transform.position = Vector3.forward * spawnZ;

		spawnZ += tile_Length;

		activeTiles.Add (go);
	}

	private void DeleteTiles()
	{
		Destroy (activeTiles [0]);
		activeTiles.RemoveAt (0);
	}
}
