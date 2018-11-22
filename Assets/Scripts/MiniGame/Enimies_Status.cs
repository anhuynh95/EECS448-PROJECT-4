/**
 * @author Team FourFour8
 * @file Enimies_Status.cs
 * @date 10/2018
 * @brief logic for enemy status
 **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * definition of enemy's health status
**/
public class Enimies_Status : MonoBehaviour {

    private int health = 100;
    /**
    * defines enemy taking damage
    * @pre damage value from bullet
    * @param dmg an integer that defines amount of damage
    * @post enemy takes damage and may alsodie if health is 0 or below
    * @return void
    **/

    
    public void TakeDmg(int dmg)
    {
        health -= dmg;
        if(health <= 0)
        {
            Debug.Log("TEST 8: ENEMY GOT HIT PASSED");
            Die();
        }
    }
    /**
   * defines enemy death
   * @pre damage value from bullet sent enemy health to 0 or below
   * @post enemy is dead
   * @return void
   **/
    void Die()
    {
        Destroy(gameObject);

    }
}
