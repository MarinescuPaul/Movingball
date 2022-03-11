using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddConstantBehavior : MonoBehaviour {
	[SerializeField]
	Vector3 vzForce=new Vector3(0,0,1);
	[SerializeField]
	Vector3 vxForce= new Vector3(1,0,0);
	[SerializeField]
	KeyCode zkeyNegative;
	[SerializeField]
	KeyCode zkeyPozitive;
	[SerializeField]
	KeyCode xkeyNegative;
	[SerializeField]
	KeyCode xkeyPozitive;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(zkeyPozitive))
			GetComponent<Rigidbody>().velocity -= vzForce;

		if (Input.GetKey(zkeyNegative))
			GetComponent<Rigidbody>().velocity += vzForce;

		if (Input.GetKey(xkeyPozitive))
			GetComponent<Rigidbody>().velocity -= vxForce;

		if (Input.GetKey(xkeyNegative))
			GetComponent<Rigidbody>().velocity += vxForce;
	}
}
