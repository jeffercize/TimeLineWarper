using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabber : MonoBehaviour {
	private RaycastHit hitInfo;
	private bool holding;
	private Transform oldParent;
	// Use this for initialization
	void Start () {
		holding = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.E)) {
			Debug.DrawRay (transform.position, transform.forward, Color.white, 10.0f, true);
			if (holding == false && Physics.SphereCast (transform.position, 0.5f, transform.forward, out hitInfo, Mathf.Infinity, (1 << 9), QueryTriggerInteraction.UseGlobal)) {
				oldParent = hitInfo.transform.parent;
				hitInfo.transform.parent = this.gameObject.transform;
				hitInfo.rigidbody.isKinematic = true;
				holding = true;
			} else if(holding == true) {
				hitInfo.transform.parent = oldParent;
				hitInfo.rigidbody.isKinematic = false;
				holding = false;
			}
		}
	}
}
