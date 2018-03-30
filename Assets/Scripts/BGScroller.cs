using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroller : MonoBehaviour {

	public float speed;
	private Renderer rend;


	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		float offset = Time.time * -speed;
		// Debug.Log (Time.time);
		// Debug.Log(Time.deltaTime);
		rend.material.SetTextureOffset ("_MainTex", new Vector2 (offset, 0));
		
	}
}
