using UnityEngine;
using System.Collections;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityStandardAssets.CrossPlatformInput;
public class prefab : MonoBehaviour {
	public prefab b;
	public bool isclick = false;
	// Use this for initialization
	void Start () {
		/*
		for(int i = 1;i<=2;i++)
		{
			Object prefab = AssetDatabase.LoadAssetAtPath("Assets/prefab/cow.prefab", typeof(GameObject));
			GameObject clone = Instantiate(prefab, Vector3.zero, Quaternion.identity) as GameObject;
			clone.transform.position = new Vector3(0, i, 0);
	
		}
		*/
		//b = GameObject.Find ("MobileSingleStickControl").transform.FindChild ("JumpButton").GetComponent<conver> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		isclick = CrossPlatformInputManager.GetButton ("Jump");

	}
	public void t(){
		#if UNITY_EDITOR
		Object prefab = AssetDatabase.LoadAssetAtPath("Assets/prefab/cow.prefab", typeof(GameObject));
		GameObject clone = Instantiate(prefab, Vector3.zero, Quaternion.identity) as GameObject;

		clone.transform.position = new Vector3(0, 0, 0);
		#endif

	}
}
