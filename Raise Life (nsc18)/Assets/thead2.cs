using UnityEngine;
using System.Collections;

public class thead2 : MonoBehaviour {

	void Start () {
		StartCoroutine("a");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	IEnumerator a(){
		for (int i = 0; i<=30; i++) {
			print ("theadbbbbb"+i);
			yield return new WaitForSeconds(0.1f);
		}
	}

}
