using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {

    public float score; //mass==score (Matthew's term)

	// Use this for initialization
	void Start () {
        transform.localScale *= score;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
