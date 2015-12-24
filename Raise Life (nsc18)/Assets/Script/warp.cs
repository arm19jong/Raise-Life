using UnityEngine;
using System.Collections;

public class warp : MonoBehaviour {

	public Transform warpTarget;
	IEnumerator OnTriggerEnter2D(Collider2D other){

		//screenfader af = GameObject.Find("MobileSingleStickControl").transform.FindChild ("Image").GetComponent<screenfader> ();
		//screenfader af = GameObject.FindGameObjectsWithTag().ge ; 
		Screenfader af = GameObject.FindGameObjectWithTag ("fader").GetComponent<Screenfader> ();

		yield return StartCoroutine (af.FadeToBlack ());


		other.gameObject.transform.position = warpTarget.position;
		//GetComponent<control_Player>().main.transform.position = warpTarget.position;

		yield return StartCoroutine (af.FadeToClear ());
	}

}
