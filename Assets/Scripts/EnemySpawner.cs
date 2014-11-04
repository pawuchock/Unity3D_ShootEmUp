using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
	public GameObject Enemy1;
	public GameObject Enemy2;
	public GameObject Enemy3;
	public float secondsBetween = 2;
	float trackTimer;
	int randomN;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{	
		randomN = Random.Range (1, 4);
		trackTimer -= Time.deltaTime;
		if (trackTimer <= 0) {
			{
				switch (randomN) {
				case 1:
					for (int i = 1; i<randomN; i++) {
						Instantiate (Enemy1, transform.position, transform.rotation);
						trackTimer = secondsBetween;
					}
					break;
				case 2:
					for (int i = 1; i<randomN; i++) {
						Instantiate (Enemy2, transform.position, transform.rotation);
						trackTimer = secondsBetween;
					}
					break;
				case 3:
					for (int i = 1; i<randomN; i++) {
						Instantiate (Enemy3, transform.position, transform.rotation);
						trackTimer = secondsBetween;
					}
					break;
				}
				
				
				
			}
			
		}
		
	}
	
}

