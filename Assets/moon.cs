using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moon : MonoBehaviour {

	public float y;

	// Update is called once per frame
	void FixedUpdate () 
	{
		Transform transform = GetComponent<Transform>();
		Vector3 angle = new Vector3(0, y + Time.deltaTime, 0);
		transform.Rotate(angle);
	}
}
