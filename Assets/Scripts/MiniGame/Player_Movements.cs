/**
 * @author Team FourFour8
 * @file Player_Movements.cs
 * @date 10/2018
 * @brief logic for player moving
 **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * definition of player movements and potential enemy interaction
**/
public class Player_Movements : MonoBehaviour {
   


    private int speed = 10;
    private bool facingRight = false;
    private int jumpPower = 1500;
    private bool isGround;
    private float moveKey;
    private bool freeze = false;
    public Animator animator;
    float horizontalMove;
    bool shoot;
    public Transform fireStart;
    public GameObject bulletPrep;

    /**
   * update is called once per frame
   * @pre none
   * @post updated frame
   * @return void
   **/
    void Update () {
        PlayerMove();
    }
    /**
   * defines how the player moves
   * @pre none
   * @post moved to desired location
   * @return void
   **/
    void PlayerMove()
    {
        if(freeze == false)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
            animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
            
            //control
            moveKey = Input.GetAxis("Horizontal");
            if (Input.GetButtonDown("Jump") && isGround == true)
            {
                Jump();
               
            }
            //player direction
            if (moveKey < 0.0f && facingRight == false)
            {
                Debug.Log("TEST 3: PLAYER MOVE LEFT PASSED");
                Flip();
            }
            else if (moveKey > 0.0f && facingRight == true)
            {
                Debug.Log("TEST 4: PLAYER MOVE RIGHT PASSED");
                Flip();
            }

            if (Input.GetButtonDown("Fire2"))
            {
                Shoot();
                animator.SetBool("isShot", true);
            }
            if (Input.GetButtonUp("Fire2"))
            {

                animator.SetBool("isShot", false);
            }

            //Physic
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveKey * speed, gameObject.GetComponent<Rigidbody2D>().velocity.y);

        }
        

    }
    /**
     * called with PlayerMove() and allows for direction change
     * @pre none
     * @post flipped direction
     * @return void
     **/
    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, -180f, 0f);
    }
    /**
   * defines how a player jump works
   * @pre none
   * @post player jumps
   * @return void
   **/
    void Jump()
    {
        Debug.Log("TEST 5: PLAYER JUMPS PASSED");
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpPower);
        isGround = false;
        animator.SetBool("isJump", true);
    }
    /**
 * defines collison of player with any object
 * @pre player collides with something
 * @post player can die, or remain fine depending on collision type
 * @param collison is a Collider2D object
 * @return void
 **/
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Wall2")
        {
            Debug.Log("TEST 6: PLAYER STANDS ON GROUND/WALL PASSED");
            isGround = true;
            animator.SetBool("isJump", false);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("TEST 6: PLAYER HITS AN ENEMY PASSED");
            freeze = true;
        }
        
    }

    void Shoot()
    {
        Instantiate(bulletPrep, fireStart.position, fireStart.rotation);
    }

}
