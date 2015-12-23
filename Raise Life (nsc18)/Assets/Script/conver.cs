using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class conver : MonoBehaviour {

	// Use this for initialization
	public bool isclick = false;
	void Start () {
	
	}

	
	// Update is called once per frame
	void FixedUpdate () {
		isclick = CrossPlatformInputManager.GetButton ("Jump");

	}


	void OnGUI() {
		if (isclick) {
			GUI.Label(new Rect(10, 10, 100, 20), "Hello World!");
		}
	}


}
