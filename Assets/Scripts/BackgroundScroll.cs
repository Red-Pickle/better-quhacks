using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour {
	private GameObject background_copy;

	private Jetpack jetpack;

	private SpriteRenderer sprite;
	private float sprite_width = 0.0f;

	private bool teleport_switch = true;

	public float speed_modifier = 1.0f;

	// Start is called before the first frame update
	void Start() {
		sprite = GetComponent<SpriteRenderer>();
		sprite_width = sprite.sprite.bounds.size.x-0.01f;
		background_copy = Instantiate(gameObject, new Vector3(sprite_width, 0, 0), Quaternion.identity);
		Destroy(background_copy.GetComponent<BackgroundScroll>());
		jetpack = GameObject.Find("Player").GetComponent<Jetpack>();
	}

	// Update is called once per frame
	void Update() {
		transform.position -= new Vector3(jetpack.speed * Time.deltaTime * speed_modifier, 0, 0);
		background_copy.transform.position -= new Vector3(jetpack.speed * Time.deltaTime * speed_modifier, 0, 0);

		if (transform.position.x <= 0 && teleport_switch) {
			background_copy.transform.position = new Vector3(sprite_width - transform.position.x, 0, 0);
			teleport_switch = false;
		} else if (background_copy.transform.position.x <= 0 && !teleport_switch) {
			transform.position = new Vector3(sprite_width - background_copy.transform.position.x, 0, 0);
			teleport_switch = true;
		}
	}
}
