using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class control_Player : MonoBehaviour {

	// Use this for initialization
	public static control_Player instance;
	public Joystick a;
	public Transform rect; 
	void Awake (){
		instance = this;
		rect = gameObject.GetComponent<Transform> ();
		a = GameObject.Find ("MobileSingleStickControl").transform.FindChild ("MobileJoystick").GetComponent<Joystick> ();
	}
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(a.moveX != 0)
			rect.Translate(0.0005f * a.moveX, 0, 0);
		if(a.moveY != 0)
			rect.Translate(0, 0.0005f * a.moveY, 0);
		//print (a.moveX+"");
		//print ("a");
	}
}
