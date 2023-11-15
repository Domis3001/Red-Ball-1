using UnityEngine;

public class Ball : MonoBehaviour
{
	public float moveForce = 1;
	Rigidbody2D rb;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		var hor = Input.GetAxis("Horizontal");
		//rb.velocity = new Vector2(hor, 0);
		rb.AddForce(new Vector2(hor * moveForce,0));

		if (Input.GetButtonDown("Jump"))
		{
			Jump();
		}
	}

	void Jump()
	{
		rb.velocity += Vector2.up * 5;
	}
}