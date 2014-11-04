using UnityEngine;
using System.Collections;

public class PlayerMovementNshooting : MonoBehaviour
{
	
	public float speed = 10.0f;
	public float minX = -Screen.width;
	public float maxX = Screen.width;
//	public  GameObject bullet;
//	public  GameObject laser;
	public static int Health ;
	// Update is called once per frame
	
	void Update ()
	{
				if (Health < 0) {
						Application.Quit ();
				}
		//transform.Translate (Input.acceleration.x, 0, 0);

				float delta = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
		
				transform.position += new Vector3 (delta, 0.0f);
		
				if (transform.position.x < minX) {
						transform.position = new Vector3 (minX, transform.position.y, transform.position.z);
				} else if (transform.position.x > maxX) {
						transform.position = new Vector3 (maxX, transform.position.y, transform.position.z);
				}
					
		//if (Stats.currentScore % 100 == 0 && Stats.currentScore != 0) {
		//	PlayerMovementNshooting.bullet = gameObject. 
}

	
	
	
	
}