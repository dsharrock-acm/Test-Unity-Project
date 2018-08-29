using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public int speed = 2;
	private Vector3 direction = new Vector3(0, 0, 0);
	private Material m;

	// Use this for initialization
	void Start () {
		 m = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update () {

		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");

		transform.Translate(Vector3.right * horizontal * speed * Time.deltaTime);
		
		transform.Translate(Vector3.up * vertical * speed * Time.deltaTime);

		if (horizontal > 0) {
			m.color = Color.red;
		} else if (horizontal < 0) {
			m.color = Color.blue;
		}
	}
}
