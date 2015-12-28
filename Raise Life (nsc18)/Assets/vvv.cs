using UnityEngine;
using System.Collections;
//using 
public class vvv : MonoBehaviour {
	private Touch touch;
	public GameObject icon;
	//public conver b;
	public control_Player con;
	int x;
	int y;
	public Vector3 touch_input;
	//Camera camera;
	Camera cameraa;
	// Use this for initialization
	void Awake(){
		//b = GameObject.Find ("MobileSingleStickControl").transform.FindChild ("JumpButton").GetComponent<conver> ();
	}
	void Start () {
		cameraa = GameObject.Find ("player").transform.FindChild ("Main Camera").GetComponent<Camera> ();
		con = GameObject.Find ("player").GetComponent<control_Player> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Debug.Log(camera.ScreenToWorldPoint(Input.mousePosition));

		if (Input.touchCount > 0) {
			touch = Input.GetTouch (0);
			if(touch.position.x>=Screen.width/2 || touch.position.y<Screen.height/2){}//con.up();}

			//if(touch.position.x>=Screen.width/2 || touch.position.y<Screen.height/3){con.up();}

			//print (".x "+touch.position.x);
			//print (".y "+touch.position.y);
			//print ("width "+Screen.width);
			//print ("hight "+Screen.height);
			//print (transform.position.x);
			//float x = -7.5f + 16 * touch.position.x / Screen.width;
			//float y = -4.5f + 10 * touch.position.y / Screen.height;
			//float x = touch.position.x + Screen.width;
			//float y = Screen.height-touch.position.y;

			//Vector2 touchPos = Input.touches[0].position;
			
			//Vector3 touchPosinWorldSpace = camera.ScreenToWorldPoint(new Vector3(touchPos.x, touchPos.y, camera.nearClipPlane));
			else{
			//con.up();
			//print("a");
			touch_input = cameraa.ScreenToWorldPoint (new Vector3(touch.position.x, touch.position.y, Camera.main.nearClipPlane));

			print (".x "+touch_input.x);
			print (".y "+touch_input.y);
			print("b");
			//x=transform.position.x;
			//x-=1;

			//if(touch.position.x){}
			transform.position = new Vector3 (touch_input.x, touch_input.y, 0);
			}
		}
	}
}
