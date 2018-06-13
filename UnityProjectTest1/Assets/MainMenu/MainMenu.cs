using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {
	public string nextLevel;
	public Image fadeout;
	public AudioSource music;
	public float fadeSpeed;

	private bool startFade;

	void Start() {
		startFade = false;
		Cursor.lockState = CursorLockMode.Confined;
	}
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.anyKey) {
			startFade = true;
		}
		if (startFade) {
			fadeout.color = new Color (fadeout.color.r, fadeout.color.g, fadeout.color.b, fadeout.color.a + fadeSpeed);
			music.volume -= fadeSpeed;
			if (fadeout.color.a >= 1) {
				SceneManager.LoadScene (nextLevel);
			}
		} else {
			fadeout.color = new Color (fadeout.color.r, fadeout.color.g, fadeout.color.b, fadeout.color.a - 0.01f);
		}
	}
}
