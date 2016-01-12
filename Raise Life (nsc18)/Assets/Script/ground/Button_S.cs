using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Button_S : MonoBehaviour {
	public  bool isclick;

	public Joystick joy;
	public Image image_joy;

	public Canvas t;

	EventTrigger.Entry entry = new EventTrigger.Entry();

	public
	// Use this for initialization
	void Start () {
		isclick = false;
		joy = GameObject.Find ("MobileSingleStickControl").transform.FindChild ("MobileJoystick").GetComponent<Joystick> ();
		image_joy = GameObject.Find ("MobileSingleStickControl").transform.FindChild ("MobileJoystick").GetComponent<Image> ();
		t= GameObject.Find ("MobileSingleStickControl").GetComponent<Canvas> ();

		

	}
	
	// Update is called once per frame
	void Update () {
	}
	public void buttondown(){
		//joy.enabled=!joy.enabled;
		//image_joy.enabled = !image_joy.enabled;
		t.enabled = !t.enabled;
		////GameObject.Find ("MobileSingleStickControl").SetActive (false);
		isclick = true;
		//t.gameObject.SetActive (false);
		//t.OnPointerDown.
	}
}
