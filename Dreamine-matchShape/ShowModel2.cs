using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowModel2 : MonoBehaviour {
	
	public GameObject target;
	int Index = 0;
	public Transform[] prefab = new Transform[3];
	bool display = true;
	bool match;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		match = target.GetComponent<ShapeRcognition2> ().match;
		Debug.Log (match);
		if (match) {
			if (display) {
				Index = target.GetComponent<ShapeRcognition2> ().currentNearest;
				Debug.Log ("Index");
				Debug.Log (Index);
				Instantiate (prefab[Index], new Vector3 (0, 0, 0), Quaternion.identity);
				display = false;
			}
		}
	}
}
