using UnityEngine;
using System.Collections;

[System.Serializable]
public class save_Ground {
	public long ID;
	public float x;
	public float y;
	public float timeleft;
	public save_Ground(long _ID, float _x, float _y, float _timeleft){
		ID = _ID;
		x = _x;
		y = _y;
		timeleft = _timeleft;
	}
}
