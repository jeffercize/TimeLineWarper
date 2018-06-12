using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switcher : MonoBehaviour {
	
	private bool startingLocation;
	public Twinner[] twinOfA;
	public Twinner[] twinOfB;
	private Twinner[,] twins;

	// Use this for initialization
	void Start () {
		if (twinOfA.Length != twinOfB.Length) {
			Debug.Log ("Critical Error the Twin listings should be the same length");
		}
		twins = new Twinner[twinOfA.Length,2];
		startingLocation = true;
		for (int i = 0; i < twinOfA.Length; i++) {
			twins [i,1] = twinOfA [i];
		}
		for (int i = 0; i < twinOfB.Length; i++) {
			twins [i,0] = twinOfB [i];
		}
		//if (twin == null) {
		Debug.Log (twins.GetLength(0));
		//}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.F)) {
			for (int i = 0; i < twins.GetLength(0); i++) {
				Debug.Log ("RAN THE LOOP");
				if (startingLocation) {
					twins [i,1].twinMotion (startingLocation);
				} else {
					twins [i,0].twinMotion (startingLocation);
				}
			}
			if (startingLocation) {
				transform.Translate(0.0f, -30.0f, 0.0f, Space.World);
				startingLocation = false;
			} else {
				transform.Translate(0.0f, 30.0f, 0.0f, Space.World);
				startingLocation = true;
			}
		}
	}
}
