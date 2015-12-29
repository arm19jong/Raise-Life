using UnityEngine;
using System.Collections;
using UnityEditor;
//#if UNITY_EDITOR
//using UnityEditor;
//#endif
public class NewBehavi : MonoBehaviour {

	// Use this for initialization
	public static NewBehavi instance;
	void Awake(){
		instance = this;
	
	}
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//print (1);
	}
	void abc(){
		print (222);
		Object prefab = AssetDatabase.LoadAssetAtPath("Assets/prefab/cow.prefab", typeof(GameObject));
		print(333);
		GameObject clone = Instantiate(prefab, Vector3.zero, Quaternion.identity) as GameObject;
		print (444);
		clone.transform.position = new Vector3(5, 2, 0);
		print(555);
	}
}
