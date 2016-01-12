using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
//using 
public class vvv2 : MonoBehaviour {
	private Touch touch;
	public GameObject icon;
	public Button_S isclicks;
	public bool a;
	//public conver b;
	//public control_Player con;
	int x;
	int y;
	public Vector3 touch_input;
	//Camera camera;
	Camera cameraa;
	// Use this for initialization
	void Awake(){
		isclicks = GameObject.Find ("MobileSingleStickControl").transform.FindChild ("ground").GetComponent<Button_S> ();
		//isclicks = GetComponent<Button_S> ().isclick;
		a = isclicks.isclick;
	}
	void Start () {
		cameraa = GameObject.Find ("player").transform.FindChild ("Main Camera").GetComponent<Camera> ();
		//con = GameObject.Find ("player").GetComponent<control_Player> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Debug.Log(camera.ScreenToWorldPoint(Input.mousePosition));
		//isclicks.
		a = isclicks.isclick;
		//print (a);
		if (a) {
			if (Input.touchCount > 0) {
				touch = Input.GetTouch (0);
				//if (touch.position.x >= Screen.width / 2 || touch.position.y < Screen.height / 2) {
				//} else {
					touch_input = cameraa.ScreenToWorldPoint (new Vector3 (touch.position.x, touch.position.y, Camera.main.nearClipPlane));
					transform.position = new Vector3 (touch_input.x, touch_input.y, 0);
				//}
			}
		}


	}
}
