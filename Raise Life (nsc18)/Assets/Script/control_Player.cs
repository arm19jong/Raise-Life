using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class control_Player : MonoBehaviour {

	// Use this for initialization
	public static control_Player instance;
	public Joystick a;
	public conver b;
	public Transform rect; 
	public float boot=1;
	Animator anim;
	void Awake (){
		instance = this;
		rect = gameObject.GetComponent<Transform> ();
		a = GameObject.Find ("MobileSingleStickControl").transform.FindChild ("MobileJoystick").GetComponent<Joystick> ();
		b = GameObject.Find ("MobileSingleStickControl").transform.FindChild ("JumpButton").GetComponent<conver> ();
	}
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (b.isclick) 
		{
			boot = 2;
		} 
		else 
		{
			boot = 1;
		}
		if (a.moveX == 0 && a.moveY == 0) {
			anim.SetBool("iswalking", false);
		}

		else if(Mathf.Abs(a.moveX)>Mathf.Abs(a.moveY)){
			anim.SetBool("iswalking", true);
			anim.SetFloat ("input_y", 0);
			if (a.moveX>0)
			{
				anim.SetFloat ("input_x", 1);
				rect.Translate ( 0.1f*boot, 0, 0);
			}
			else
			{
				anim.SetFloat ("input_x", -1);
				rect.Translate ( -0.1f*boot, 0, 0);
			}
		}
		else if(Mathf.Abs(a.moveX)<=Mathf.Abs(a.moveY)){

			anim.SetBool("iswalking", true);
			anim.SetFloat ("input_x", 0);
			if(a.moveY>0)
			{
				anim.SetFloat ("input_y", 1);
				rect.Translate (0, 0.1f *boot, 0);
			}
			else
			{
				anim.SetFloat ("input_y", -1);
				rect.Translate (0, -0.1f *boot, 0);
			}

		}


		//print (a.moveX+"//"+a.moveY);
		//print ("a");
	}
}
