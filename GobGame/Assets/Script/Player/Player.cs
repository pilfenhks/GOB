using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    Camera cam;
	void Start () {
        cam = Camera.main;
        cam.transform.parent = this.transform;
	}
	
	void Update () {
		
	}
}
