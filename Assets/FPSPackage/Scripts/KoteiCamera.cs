using UnityEngine;
using System.Collections;

public class KoteiCamera: MonoBehaviour {
	public GameObject player;

 void Start (){ 
	}
		
	void Update(){
		transform.position = player.transform.position + new Vector3 (0,5, 0);
	}
}
