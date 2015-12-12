﻿using UnityEngine;
using System.Collections;

public class PlayerSpawn : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		GameObject player = (GameObject)Instantiate (Resources.Load ("Player"));
		player.name = "Player";

		GameObject camera = (GameObject)Instantiate (Resources.Load ("CameraContainer"));
		camera.BroadcastMessage ("SetTarget", player.transform);

		Instantiate (Resources.Load ("UI"));

		Instantiate (Resources.Load ("EventSystem"));

		player.transform.position = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
