using UnityEngine;
using System.Collections;

public class objna_s : MonoBehaviour {

	// Use this for initialization
	private SpriteRenderer tree1;
	private SpriteRenderer bg;
	private BoxCollider2D box;
	void Start () {
		tree1 = gameObject.transform.FindChild ("tree1").GetComponent<SpriteRenderer> ();
		tree1.enabled = false;
		bg = gameObject.transform.FindChild ("bg").GetComponent<SpriteRenderer> ();
		bg.enabled = false;
		box = gameObject.transform.FindChild ("tree1").GetComponent<BoxCollider2D> ();
		box.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown (){
		tree1.enabled = !tree1.enabled;
		bg.enabled = !bg.enabled;
		box.enabled = !box.enabled;
	}
}
