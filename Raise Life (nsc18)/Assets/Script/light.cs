using UnityEngine;
using System.Collections;
[RequireComponent( typeof( Light ) )]
public class light : MonoBehaviour {
	float a=0;
	GameObject lightGameObject ;
	Light lightComp;
	
	float newS, sMin, sMax, newMin = 0, newMax = 1;

	void Start () {
		lightGameObject = new GameObject("Directional lightuuuuu");
		lightComp = lightGameObject.AddComponent<Light>();
		lightComp.type = LightType.Directional;
	}
	void Update () {
		a += Time.deltaTime;
		if (a >= 20) {
			a = 0;
		} 
		else if (a >= 10) {
			sMin = 10;
			sMax = 19;
			newS =  (((a - sMin) * (newMax - newMin)) / (sMax - sMin)) + newMin;
			lightComp.color = Color.Lerp (new Color(1,0.171f, 1,1),Color.white, newS);
			lightGameObject.transform.position = new Vector3(8, 2, -1);
		}
		else{
			sMin = 0;
			sMax = 9;
			newS =  (((a - sMin) * (newMax - newMin)) / (sMax - sMin)) + newMin;
			lightComp.color = Color.Lerp (Color.white,new Color(1,0.171f, 1,1), newS);
			lightGameObject.transform.position = new Vector3(8, 2, -1);
		}
		print (a);
	}
	void redtowhite(){
		lightComp.color = Color.Lerp (new Color(1,0.171f, 1, 1), Color.white,9.9f);
		lightGameObject.transform.position = new Vector3(8, 2, -1);
	}
	void whitetored(){
		print (lightComp.color);
		//if (lightComp.color.r == 1 && lightComp.color.g==0.171 && lightComp.color.b==1) {
		//	return;
		//}
		lightComp.color = Color.Lerp (Color.white,new Color(1,0.171f, 1,1), 9f);
		lightGameObject.transform.position = new Vector3(8, 2, -1);
	}


}
