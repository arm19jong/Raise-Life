using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using System;

public class control_Player : MonoBehaviour {

	// Use this for initialization
	//public GameObject aaa;
	public static control_Player instance;
	public Joystick a;
	//public conver b;
	public Transform rect; 
	public Rigidbody2D rb;
	public float boot=1;
	public bool isclick=false;
	Animator anim;
	void Awake (){
		instance = this;
		rect = gameObject.GetComponent<Transform> ();
		rb = gameObject.GetComponent<Rigidbody2D> ();
		a = GameObject.Find ("MobileSingleStickControl").transform.FindChild ("MobileJoystick").GetComponent<Joystick> ();
		//b = GameObject.Find ("MobileSingleStickControl").transform.FindChild ("JumpButton").GetComponent<conver> ();
	}
	void Start () {
		anim = GetComponent<Animator> ();
		//print (""+DateTime.Now.Year);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (isclick) 
		{
			boot = 2;
			anim.speed = 1.4f;
		} 
		else 
		{
			boot = 1;
			anim.speed=0.7f;
			//anim.
		}
		if (a.moveX == 0 && a.moveY == 0) {
			anim.SetBool("iswalking", false);
			//rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
		}

		else if(Mathf.Abs(a.moveX)>Mathf.Abs(a.moveY)){
			//rb.constraints = RigidbodyConstraints2D.FreezeRotation;
			anim.SetBool("iswalking", true);
			anim.SetFloat ("input_y", 0);
			if (a.moveX>0)
			{
				anim.SetFloat ("input_x", 1);
				rect.Translate ( 0.1f*boot, 0, 0);
				//rb.position += new Vector2(0.1f*boot, 0);
			}
			else
			{
				anim.SetFloat ("input_x", -1);
				rect.Translate ( -0.1f*boot, 0, 0);
				//rb.position += new Vector2(-0.1f*boot, 0);
			}
		}
		else if(Mathf.Abs(a.moveX)<=Mathf.Abs(a.moveY)){

			anim.SetBool("iswalking", true);
			anim.SetFloat ("input_x", 0);
			if(a.moveY>0)
			{
				anim.SetFloat ("input_y", 1);
				rect.Translate (0, 0.1f *boot, 0);
				//rb.position += new Vector2(0, 0.1f *boot);
			}
			else
			{
				anim.SetFloat ("input_y", -1);
				rect.Translate (0, -0.1f *boot, 0);
				//rb.position += new Vector2(0, -0.1f *boot);
			}

		}


		//print (a.moveX+"//"+a.moveY);
		//print ("a");
	}
	public void down(){
		isclick = true;
		FixedUpdate ();
	}
	public void up(){
		isclick = false;
		FixedUpdate ();
	}
	public void save(){
		SaveClass.s.Splayer.x = gameObject.transform.position.x;
		SaveClass.s.Splayer.y = gameObject.transform.position.y;
	}
	public void load(){
		gameObject.transform.position  = new Vector2( SaveClass.s.Splayer.x, SaveClass.s.Splayer.y);
	}
}
