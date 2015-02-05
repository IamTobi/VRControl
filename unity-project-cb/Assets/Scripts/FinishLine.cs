using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FinishLine : MonoBehaviour {

	public Text text;
	public string finishLineText;
	public float restartTime;
	// Use this for initialization
	void Start () {
		text.text = "";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other){
		Debug.Log ("Finish reached");
		if (other.tag == "Player") {
			text.text= ""+finishLineText;

			StartCoroutine (countdown());

		}
	}
	IEnumerator countdown(){
		yield return new WaitForSeconds(2);
		while(restartTime >0){
			yield return new WaitForSeconds(1);
			text.text="Restart in " + restartTime.ToString();
			restartTime-=1;
		}

		text.text="Starte neu";
		Invoke("restartLevel",1f);
	}

	void restartLevel(){
		Application.LoadLevel(Application.loadedLevel);
	}
}
