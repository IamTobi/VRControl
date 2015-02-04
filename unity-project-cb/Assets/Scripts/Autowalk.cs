using UnityEngine;
using System.Collections;

public class Autowalk : MonoBehaviour {

	private CardboardHead head;
	private Vector3 startPosition;

	// Use this for initialization
	void Start () {
		head = Camera.main.GetComponent<StereoController>().Head;
		startPosition = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {

		if(Cardboard.SDK.CardboardTriggered){
			GameObject FPSController = GameObject.Find ("Head");
			FPSInputController autowalk = FPSController.GetComponent<FPSInputController>();
			autowalk.checkAutoWalk = !autowalk.checkAutoWalk;
		}
	}
}
