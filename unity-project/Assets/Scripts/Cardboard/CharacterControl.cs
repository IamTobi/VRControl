using UnityEngine;
using System.Collections;

public class CharacterControl : MonoBehaviour {

	private bool triggered;

	// Use this for initialization
	void Start () {

		triggered=false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Cardboard.SDK.CardboardTriggered) {
			while(triggered=false){
				transform.Translate(Vector3.forward*Time.deltaTime);
			}

		}
	}
}
