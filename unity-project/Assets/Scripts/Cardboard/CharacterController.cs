using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {
	
	private Vector3 startPosition,endPosition;

	// Use this for initialization
	void Start () {
		startPosition = new Vector3(0,0,0);
		endPosition = new Vector3(0,0,15);
	}
	
	// Update is called once per frame
	void Update () {
		if(Cardboard.SDK.CardboardTriggered){
			this.transform.Translate(Vector3.forward *Time.deltaTime);
		}
	
	}

	void MoveCamera(Transform thisTransform, float time,Vector3 startPos, Vector3 endPos){
		float i = 0f;
		float rate = 1f/time;
		thisTransform.position = Vector3.Lerp (startPos,endPos,i);
	}
}
