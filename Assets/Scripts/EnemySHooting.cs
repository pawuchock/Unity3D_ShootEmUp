using UnityEngine;
using System.Collections;

public class EnemySHooting : MonoBehaviour {
	public GameObject bullet;
	// Use this for initialization
	public float fireCoolDOwn;
	
	// Update is called once per frame
	void Update () 
	{	
		fireCoolDOwn -= Time.deltaTime;
		if (fireCoolDOwn < 0.0f) 
		{	Wait ();
			Fire ();
			Wait();
		}
	}
	void Wait()
	{
		fireCoolDOwn = Random.Range (0.1f, 8.0f);
	}
	void Fire()
	{
		Instantiate(bullet,transform.position, Quaternion.identity);
	}
}
