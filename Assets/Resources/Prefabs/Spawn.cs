using UnityEngine;
using System.Collections.Generic;

public class Spawn : MonoBehaviour {

    public GameObject asteroidPrefab;
    private List<GameObject> asteroids;
	// Use this for initialization
	void Start () {

        if (asteroidPrefab == null)
        {
            Debug.LogWarning("Please attach asteroid prefab to this screipt! Dingus!");
            return;
        }

        asteroids = new List<GameObject>();
        for(int i = 0; i < 20; i++){
            Vector3 randomPos = new Vector3(Random.Range(-20f, 20f), Random.Range(-20f, 20f), 0f);
            GameObject asteroid = (GameObject)Instantiate(asteroidPrefab, randomPos, Quaternion.identity);
            asteroids.Add(asteroid);
            asteroid.transform.parent = transform;
            SpriteRenderer sr = asteroid.GetComponent<SpriteRenderer>();
            sr.material.color = new Color(Random.Range(0f, 1f),0,0);
            Asteroid itsScript = asteroid.AddComponent<Asteroid>();
            itsScript.score = Random.Range(0.1f, 3f);     


        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
