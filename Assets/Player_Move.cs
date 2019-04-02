using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour {

    public int PlayerSpeed = 100;
    private bool facingRight = true;
    public int playerJumpPower = 1250;
    private float moveX;

	// Update is called once per frame
	void Update () {

        PlayerMove();

	}

    void PlayerMove()
    {
        //controls
        moveX = Input.GetAxis("Horizontal");
        if (Input.GetButton("Jump")) { Jump(); }


        //animations


        //player directions
        if (moveX < 0.0f && facingRight == false)
        {
            FlipPlayer();
        }
        else if (moveX >0.0f && facingRight == true)
        {
            FlipPlayer();
        }
        //physics

        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * PlayerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);

        //GetComponent<Rigidbody2D>.velocity.y
    }

    void Jump()
    {
        //int bool impact;
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);

    }

    void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale; 
        localScale.x *= -1;
        transform.localScale = localScale ;
    }


}
