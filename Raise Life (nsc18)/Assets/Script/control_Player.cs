using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class control_Player : MonoBehaviour {

	// Use this for initialization
	public static control_Player instance;
	public Joystick a;
	public Transform rect; 
	Animator anim;
	void Awake (){
		instance = this;
		rect = gameObject.GetComponent<Transform> ();
		a = GameObject.Find ("MobileSingleStickControl").transform.FindChild ("MobileJoystick").GetComponent<Joystick> ();
	}
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (a.moveX != 0) {
			rect.Translate (0.0008f * a.moveX, 0, 0);
			anim.SetBool("iswalking", true);
			anim.SetFloat ("input_x", a.moveX);
		}
		if (a.moveY != 0) {
			rect.Translate (0, 0.0008f * a.moveY, 0);
			anim.SetBool("iswalking", true);
			anim.SetFloat ("input_y", a.moveY);
		}
		if (a.moveX == 0 && a.moveY == 0) {
			anim.SetBool("iswalking", false);
		}
		//print (a.moveX+"");
		//print ("a");
	}
}
