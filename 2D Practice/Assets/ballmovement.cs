using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.RightArrow)){
			transform.Translate (Vector3.right * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate (Vector3.left * Time.deltaTime);
		}


	}

	int calc(){
		return 1;
	}
}
