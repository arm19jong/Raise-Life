using UnityEngine;
using System.Collections;

public class aii : MonoBehaviour {
	float timeLeft = 0.0f;
	Transform rect;
	Rigidbody2D rb;
	public static aii instance;
	int randomxy = 0;
	int randomint = 0;
	Animator anim;
	bool cons;
	// Use this for initialization
	void Start () {
		cons = false;
		anim = GetComponent<Animator> ();
		instance = this;
		rect = gameObject.GetComponent<Transform> ();
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		timeLeft -= Time.deltaTime;
		if (cons == true) {
			gen ();
			return;
		}
		if (timeLeft <= 0) {
			timeLeft = Random.Range(1, 4);
			anim.SetBool("iswalking", false);
			//randomxy = Random.Range(0,2);

			randomint = Random.Range(-10, 11);
			if(randomint<0){randomxy=0;}
			else{randomxy=1;}

			if (randomxy==0)
			{
				randomint = Random.Range(-10, 11);
				if(randomint<0){randomint=-1;}
				else{randomint=1;}
				anim.SetFloat ("input_x", randomint);
				anim.SetFloat ("input_y", 0);
			}
			else
			{
				randomint = Random.Range(-10, 11);
				if(randomint<0){randomint=-1;}
				else{randomint=1;}
				anim.SetFloat ("input_y", randomint);
				anim.SetFloat ("input_x", 0);
			}
		} 
		//walk
		if (timeLeft < 2) {
			//rb.constraints = RigidbodyConstraints2D.FreezeRotation;
			anim.SetBool ("iswalking", true);
			//anim.SetFloat ("input_x", 1);
			//rect.Translate ( 0.01f, 0, 0);
			if (randomxy == 0) {
				rect.Translate (0.01f * randomint, 0, 0);
				//rb.position += new Vector2(0.1f*randomint, 0);
			} else {
				rect.Translate (0, 0.01f * randomint, 0);
				//rb.position += new Vector2(0, 0.1f*randomint);
			}
		}
		//stop
		else {
			anim.SetBool ("iswalking", false);
			//rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
			//anim.SetFloat ("input_x", 0);
		}
	}
	void gen(){
			if (Input.GetKeyDown (KeyCode.V)) {
				print ("ttt");
		}
	}
	void OnCollisionStay2D(Collision2D coll) {
		//rect.Translate (0, 0, 0);

		cons = true;
		anim.SetBool ("iswalking", false);
		print (1);
	}
	void OnCollisionExit2D(Collision2D coll) {
		cons = false;
		anim.SetBool ("iswalking", true);
	}
}
