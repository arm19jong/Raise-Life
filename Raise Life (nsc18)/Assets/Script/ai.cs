using UnityEngine;
using System.Collections;

public class ai : MonoBehaviour {
	public Transform rect; 
	// Use this for initialization
	void Start () {
		rect = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		rect.Translate (0, -0.01f, 0);
	}
}
