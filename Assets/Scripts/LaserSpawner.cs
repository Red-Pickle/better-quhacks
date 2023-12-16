using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;

public class LaserSpawner : MonoBehaviour {
	public GameObject laser_prefab;
	public int spawn_bounds_from_center = 4;
	public float spawn_delay = 3;
	public ScoreManager sm;
	private bool spawn = true;
	public List<GameObject> lasers = new List<GameObject>();
	private float camera_width;

    // Start is called before the first frame update
    void Start() {
		camera_width = Camera.main.aspect * 2.0f * Camera.main.orthographicSize;
    }

	// Update is called once per frame
	void Update() {
		
		if (spawn && sm.currentGameState == states.INGAME) {
			UnityEngine.Debug.Log(camera_width);
			lasers.Add(Instantiate(laser_prefab, new Vector3(
				camera_width + UnityEngine.Random.Range(1.0f, camera_width),
				UnityEngine.Random.Range(-spawn_bounds_from_center, spawn_bounds_from_center),
				0.0f), Quaternion.identity));
			spawn = false;
			StartCoroutine(wait_for_spawn());
			
        }
	}

	IEnumerator wait_for_spawn() {
		yield return new WaitForSeconds(spawn_delay);
		spawn = true;
	}
}
