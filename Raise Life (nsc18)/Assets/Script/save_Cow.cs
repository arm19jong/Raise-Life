using UnityEngine;
using System.Collections;

[System.Serializable]
public class save_Cow {
	public long ID;
	public float x;
	public float y;
	public save_Cow(long _ID, float _x, float _y){
		ID = _ID;
		x = _x;
		y = _y;
	}

}
