using UnityEngine;
using System.Collections;

public class boxtest : MonoBehaviour {

	bool oncon=false;
	void OnTriggerEnter2D(Collider2D other){
	
		oncon = true;
	
	}

	void OnGUI() {
		if (oncon) {
			GUI.Label (new Rect (10, 10, 100, 20), "Hello---");
		}
	}
}
