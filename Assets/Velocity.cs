using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocity : MonoBehaviour {

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
			rb = GetComponent<Rigidbody>();
	}

	public void IncreaseVelocity(){
		  // foreach(val in rb.velocity){
			// 		val
			// }
			rb.velocity += rb.velocity*0.1f;
	}

	public void DecreaseVelocity(){
			// rb.velocity -= rb.velocity*0.1f;
			rb.velocity = new Vector3(10.0f,10.0f,10.0f);
			Debug.Log("Tests");
	}

	// Update is called once per frame
	void Update () {

	}
}
