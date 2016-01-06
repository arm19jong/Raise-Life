using UnityEngine;
using System.Collections;
[RequireComponent( typeof( Light ) )]
public class light : MonoBehaviour {
	float a=0;
	GameObject lightGameObject ;
	Light lightComp;
	time times;
	
	float newS, sMin, sMax, newMin = 0, newMax = 1;

	void Start () {
		lightGameObject = new GameObject("Directional lightuuuuu");
		lightComp = lightGameObject.AddComponent<Light>();
		lightComp.type = LightType.Directional;
		times = GameObject.Find ("player").transform.FindChild ("GameObject").GetComponent <time>();
	}
	void Update () {
		a = times.hours;
		//a += Time.deltaTime;
		if (a >= 23) {
			a = 0;
		} 
		else if (a >= 1&&a<15) {
			sMin = 2;
			sMax = 8;
			newS =  (((a - sMin) * (newMax - newMin)) / (sMax - sMin)) + newMin;
			lightComp.color = Color.Lerp (Color.black, Color.white, newS);
			lightGameObject.transform.position = new Vector3(8, 2, -1);
		}
		else if(a>=15){
			sMin = 15;
			sMax = 21;
			newS =  (((a - sMin) * (newMax - newMin)) / (sMax - sMin)) + newMin;
			//lightComp.color = Color.Lerp (Color.white,new Color(1,0.171f, 1,1), newS);
			lightComp.color = Color.Lerp (Color.white, Color.black, newS);
			lightGameObject.transform.position = new Vector3(8, 2, -1);
		}
		//print (a);
	}

}
