using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour {


	public float speed;
	private Rigidbody2D rb;
	public GameObject laserHit;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = new Vector2 (-speed, rb.velocity.y);
	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("Collision");
		Instantiate(laserHit, other.transform.position, other.transform.rotation);
		Destroy (other.gameObject);
	}
		
}
