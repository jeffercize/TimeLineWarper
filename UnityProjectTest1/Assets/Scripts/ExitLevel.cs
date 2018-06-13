using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevel : MonoBehaviour {
	public GameObject player;
	public string nextLevel;

	void OnTriggerEnter (Collider other){
		Debug.Log (other.gameObject); 
		if (other.gameObject == player) {
			SceneManager.LoadScene (nextLevel);
		}
	}
}
