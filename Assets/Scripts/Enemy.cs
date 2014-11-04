using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
	public static float enemySpeed = 1.0f;
	Vector3 pos;
	float x;
	// Use this for initialization
	void Start ()
	{
		{
			x = Random.Range (-Screen.width,Screen.width);
			pos = new Vector3 (x, 8, 0);
			transform.position = pos;
			
		}
	}
	
	void Update ()
	{
		rigidbody2D.velocity = -new Vector2 (0.0f, enemySpeed);
		if (transform.position.y < -9) {
			Destroy(gameObject);			}
	}
	void OnCollisionEnter2D(Collision2D coll)
	{ 
				if (coll.gameObject.tag == "Enemy") {
						Destroy (gameObject);
						Destroy (coll.gameObject);
				}
		}
	// Update is called once per frame
	
}