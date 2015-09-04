using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    Rigidbody2D rb;
    public float speed = 2f;
    public float maxSpeed = 8f;
    public Vector2 drag = new Vector2(0.1f, 0.1f);

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        if (x == 0 && rb.velocity.x != 0) x = -(Mathf.Sign(rb.velocity.x));
        if (y == 0 && rb.velocity.y != 0) y = -(Mathf.Sign(rb.velocity.y));
        Vector2 goHere = new Vector2(x, y) * speed;
        float ogSignX = (rb.velocity.x == 0) ? Mathf.Sign(x) : Mathf.Sign(rb.velocity.x);
        float ogSignY = (rb.velocity.y == 0) ? Mathf.Sign(y) : Mathf.Sign(rb.velocity.y);
        rb.velocity += goHere;
        float tempX = 0, tempY = 0;
        tempX = (ogSignX != Mathf.Sign(rb.velocity.x)) ? 0 : ((rb.velocity.x > maxSpeed) ? maxSpeed : rb.velocity.x);
        tempY = (ogSignY != Mathf.Sign(rb.velocity.y)) ? 0 : (rb.velocity.y > maxSpeed) ? maxSpeed : rb.velocity.y;
        rb.velocity = new Vector2(tempX, tempY);
	}
}
