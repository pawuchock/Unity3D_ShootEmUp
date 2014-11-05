using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
	public static float enemySpeed = 1.0f;
	Vector3 pos;
	float x;
	private	UnityEngine.Touch t;
	public GameObject obj;


	// Use this for initialization
	void Start ()
	{
		{
			x = Random.Range (-20,16);
			pos = new Vector3 (x, 23, 0);
			transform.position = pos;
		}
	}
	
	void Update ()
	{
				rigidbody2D.velocity = -new Vector2 (0.0f, enemySpeed);
				if (transform.position.y < -9) 
					{
						Destroy (gameObject);			
					}
				if (Input.touchCount == 1) 
				{
						t = Input.GetTouch (0);
						if (t.phase == TouchPhase.Ended && t.tapCount == 1 ) 
						{ 	
				Ray ray = Camera.main.ScreenPointToRay(t.position);
				RaycastHit2D hit = Physics2D.Raycast(ray.origin,ray.direction);
				obj = hit.collider.gameObject;
								
					
			
			
						}
				}
		}
	void OnCollisionEnter2D(Collision2D coll)
	{ 
				if (coll.gameObject.tag == "Enemy") 
				{
						Destroy (gameObject);
						Destroy (coll.gameObject);
				}
	}
	// Update is called once per frame
	
}
