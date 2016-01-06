using UnityEngine;
using System.Collections;
using System.Collections.Generic; 
using System.Runtime.Serialization.Formatters.Binary; 
using System.IO;

public class save_load : MonoBehaviour {
	public static List<SaveClass> savedGames = new List<SaveClass>();
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.S)) {
			//SaveClass.s = new SaveClass();
			GameObject.Find ("player").GetComponent<control_Player>().save();
			save();
			//print("S"+SaveClass.s.Splayer.x.ToString()+"//"+SaveClass.s.Splayer.y.ToString());
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			load();
			//print("L"+SaveClass.s.Splayer.x.ToString()+"//"+SaveClass.s.Splayer.y.ToString());
			GameObject.Find ("player").GetComponent<control_Player>().load();
		}
	
	
	}
	void save(){

		if (savedGames.Count == 0) {
			savedGames.Add (SaveClass.s);
		}else{
			savedGames[0] = SaveClass.s;
		}

		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create (Application.persistentDataPath + "/savedGames.gd");
		bf.Serialize(file, savedGames);
		file.Close();
		print("done at " + Application.persistentDataPath + "/savedGames.gd");
	}
	void load(){
		try{
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/savedGames.gd", FileMode.Open);
			savedGames = (List<SaveClass>)bf.Deserialize(file);
			SaveClass.s = savedGames[0];
			//print ()
			file.Close();

			print ("load done");

		}catch{
			print ("Error");
		}
	}
}
