using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBar : MonoBehaviour {

	public GameObject pauseMenu;

	private void Start()
	{
		pauseMenu.SetActive (false);
	}

	public void TogglePause()
	{
		pauseMenu.SetActive (!pauseMenu.activeSelf);
	}
}
