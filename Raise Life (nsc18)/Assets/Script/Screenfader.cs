using UnityEngine;
using System.Collections;

public class Screenfader : MonoBehaviour {

	Animator anim;
	bool isFading = false;

	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator>();
		print ("2");
	}

	public IEnumerator FadeToClear(){
		isFading = true;
		anim.SetTrigger ("FadeIn");
		while (isFading)
			yield return null;

	}
	public IEnumerator FadeToBlack(){
		isFading = true;
		anim.SetTrigger ("FadeOut");
		
		while (isFading)
			yield return null;
	}
	
	// Update is called once per frame
	void AnimationComplete () {
		isFading = false;
	}
}
