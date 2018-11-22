/**
 * @author Team FourFour8
 * @file Bullet.cs
 * @date 10/2018
 * @brief logic for player's bullets
 **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * defines behavior a bullet
**/
public class E_Bullet : MonoBehaviour
{
    private float speed = 5f;
    public Rigidbody2D temp;
    private int damage = 50;
    private int frame = 0;
    private bool isShot;
    // Use this for initialization
    /**
     * used for initialization
     * @pre none
     * @post isShot is true and velocity changes
     * @return void
     **/
    void Start()
    {
        temp.velocity = transform.right * speed;
        isShot = true;
    }
    /**
     * update is called once per frame
     * @pre none
     * @post updated frame
     * @return void
     **/
    void Update()
    {
        if (frame < 40)
        {
           
            frame++;
        }
        else
        {
            frame = 0;
            isShot = false;
            Destroy(gameObject);
        }
    }
    /**
     * defines collison of bullet
     * @pre bullet must be fired
     * @post if it collides with enemy,damage is dealt
     * @param collison is a Collider2D object
     * @return void
     **/
    private void OnTriggerEnter2D(Collider2D collision)
    {

        Player_Status player = collision.GetComponent<Player_Status>();
        if (player != null)
        {
            Debug.Log("TEST 10: ENEMY SHOT PLAYER PASSED");
            player.TakeDmg(damage);
        }
        Destroy(gameObject);

    }
}
