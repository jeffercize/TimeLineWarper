using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Twinner : MonoBehaviour {
	public GameObject twin;

	// Use this for initialization
	void Start () {
		if (twin == null) {
			Debug.Log (this.gameObject.name + "has no twin, but should");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void twinMotion(bool startingLocation){
		this.transform.position = twin.transform.position;
		this.transform.rotation = twin.transform.rotation;
		if (startingLocation) {
			transform.Translate(0.0f, -30.0f, 0.0f, Space.World);
		} else {
			transform.Translate(0.0f, 30.0f, 0.0f, Space.World);
		}

	}
}
