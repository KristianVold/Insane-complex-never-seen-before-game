using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour {


	public int playerMovementSpeed;


	// Use this for initialization
	void Start () {

	

		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W))
			transform.Translate(Vector3.forward * Time.deltaTime);

		if (Input.GetKey (KeyCode.D))
			transform.Translate(Vector3.right * Time.deltaTime);

		if (Input.GetKey (KeyCode.A))
			transform.Translate(Vector3.left * Time.deltaTime);

		if (Input.GetKey (KeyCode.Space))
			transform.Translate(Vector3.up * Time.deltaTime);


}
}