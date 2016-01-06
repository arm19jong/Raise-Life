using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class warp : MonoBehaviour {
	public Joystick a;
	public void Start (){
		a = GameObject.Find ("MobileSingleStickControl").transform.FindChild ("MobileJoystick").GetComponent<Joystick> ();
	}

	public Transform warpTarget;
	IEnumerator OnTriggerEnter2D(Collider2D other){
		//a.OnDisable ();
		//screenfader af = GameObject.Find("MobileSingleStickControl").transform.FindChild ("Image").GetComponent<screenfader> ();
		//screenfader af = GameObject.FindGameObjectsWithTag().ge ; 
		Screenfader af = GameObject.FindGameObjectWithTag ("fader").GetComponent<Screenfader> ();

		yield return StartCoroutine (af.FadeToBlack ());


		other.gameObject.transform.position = warpTarget.position;
		//GetComponent<control_Player>().main.transform.position = warpTarget.position;

		yield return StartCoroutine (af.FadeToClear ());
	}

}
