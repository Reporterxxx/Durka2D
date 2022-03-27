using UnityEngine;

public class MovePlayer : MonoBehaviour
{
	public float horisontalSpeed;
	float speedX;
	public float verticalSpeed;
	float speedY;
	Rigidbody2D rb;
	bool isGrounded;
	
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate () {
		if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
		{
			speedX = horisontalSpeed / 2;
			speedY = verticalSpeed / 2;
		}
		else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
		{
			speedX = -horisontalSpeed / 2;
			speedY = verticalSpeed / 2;
		}
		else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
		{
			speedX = horisontalSpeed / 2;
			speedY = -verticalSpeed / 2;
		}
		else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
		{
			speedX = -horisontalSpeed / 2;
			speedY = -verticalSpeed / 2;
		}
		else if (Input.GetKey(KeyCode.A))
		{
			speedX = - horisontalSpeed;
		}
		else if (Input.GetKey(KeyCode.D))
		{
			speedX = horisontalSpeed;
		}
		else if (Input.GetKey(KeyCode.S))
		{
			speedY = -verticalSpeed;
		}
		else if (Input.GetKey(KeyCode.W))
		{
			speedY = verticalSpeed;
		}
		
		transform.Translate(speedX, speedY, 0);
		speedX = 0;
		speedY = 0;
	}
			
	
}
