using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour {
	
	public float speed = 3.0f;
	public int pointValue = 10;
	// Update is called once per frame
	void FixedUpdate () {
		rigidbody2D.velocity = new Vector2(0.0f, speed);
		if (transform.position.y > 22)
			Destroy (gameObject);

	}
	void OnTriggerEnter2D(Collider2D coll)
	{ 
				if (coll.gameObject.tag == "Enemy") 
				{
						Destroy (gameObject);
						Destroy (coll.gameObject);
				}

			
	}
}