using UnityEngine;
//using System;
using System.Collections;


public class cow : MonoBehaviour {
	float timeLeft = 0.0f;
	public Transform rect;
	public static cow instance;
	int randomxy = 0;
	int randomint = 0;
	int x=0;
	int y=0;

	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		instance = this;
		rect = gameObject.GetComponent<Transform> ();
		//print (""+DateTime.Now.Year);
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;

		if (timeLeft <= 0) {
			//print ("e");
			timeLeft = 4.0f;
			anim.SetBool("iswalking", false);
			randomxy = Random.Range(0,2);

			if (randomxy==0)
			{
				x+=1;
				while(randomint==0){
				randomint = Random.Range(-1, 2);
				}
				anim.SetFloat ("input_x", randomint);
				anim.SetFloat ("input_y", 0);

			}
			else
			{
				y+=1;
				while(randomint==0){
					randomint = Random.Range(-1, 2);
				}
				anim.SetFloat ("input_y", randomint);
				anim.SetFloat ("input_x", 0);

			}


			print (x+"//"+y);
		} 
		//walk
		if (timeLeft < 2) 
		{
			anim.SetBool("iswalking", true);
			//anim.SetFloat ("input_x", 1);
			//rect.Translate ( 0.01f, 0, 0);
			if(randomxy==0)
			{
				rect.Translate ( 0.01f*randomint, 0, 0);
			}
			else
			{
				rect.Translate ( 0, 0.01f*randomint, 0);
			}
		}
		//stop
		else 
		{
			anim.SetBool("iswalking", false);
			//anim.SetFloat ("input_x", 0);
		}
	}
}
