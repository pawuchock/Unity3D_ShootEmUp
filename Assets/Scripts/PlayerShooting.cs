using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {
	public  GameObject bullet;
	public  GameObject laser;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnGUI () {

		if (GUI.Button (new Rect (Screen.width - 200,Screen.height - 100, 200, 100), "Fire")) {
				if (Random.Range (1, 15) == 3) {
					Instantiate (laser, transform.position, Quaternion.identity);
				} else {
				audio.Play();
					Instantiate (bullet, transform.position, Quaternion.identity);
				}
			}

		
	}
}
