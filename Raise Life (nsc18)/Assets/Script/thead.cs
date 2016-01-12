using UnityEngine;
using System.Collections;

public class thead : MonoBehaviour {

	void Start () {
		StartCoroutine("a");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	IEnumerator a(){
		while (true) {
			print ("a");
			yield return new WaitForSeconds(1);
		}
	}

}
