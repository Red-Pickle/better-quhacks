using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
	
	// Start is called before the first frame update
	void Start() {
		GetComponent<Rigidbody2D>().AddTorque(15.0f);
	}

	// Update is called once per frame
	void Update() {

	}
}
