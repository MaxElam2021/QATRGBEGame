using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public float moveSpeed = 5f;
	
	public Rigidbody2D rb;
	public Animator animator; 

	Vector2 movement;

	public bool onPlatform = false;

	public bool canMove = true;

    // Update is called once per frame
    void Update()
    {
			movement.x = Input.GetAxisRaw("Horizontal");
			movement.y = Input.GetAxisRaw("Vertical");

			animator.SetFloat("Horizontal", movement.x);
			animator.SetFloat("Vertical", movement.y);
			animator.SetFloat("Speed", movement.sqrMagnitude);
    }

	void FixedUpdate()
	{

		if (canMove) 
		{
			//rb.MovePosition(rb.position + movement * moveSpeed); (This is shaded as that this doesn't work in the moving platforms)
			rb.velocity = moveSpeed * movement;
		}
		else
        {
			rb.velocity = Vector3.zero;
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Pickups"))
		{
			Destroy(other.gameObject);
		}
	}

	public void DialogEnter() {
		animator.SetFloat("Horizontal", 0);
		animator.SetFloat("Vertical", 0);
		animator.SetFloat("Speed", 0);
		canMove = false;
	}

	public void DialogExit() {
		canMove = true;                  
	}
}
