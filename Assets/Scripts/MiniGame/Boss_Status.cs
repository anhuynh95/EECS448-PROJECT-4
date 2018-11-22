using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Status : MonoBehaviour {

    private int health = 2500;
  
    
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
        if (health <= 0)
        {
           
            Debug.Log("TEST 13: BOSS GOT HIT PASSED");
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
