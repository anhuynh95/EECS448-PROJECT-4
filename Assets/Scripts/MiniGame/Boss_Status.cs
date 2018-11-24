
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Boss_Status : MonoBehaviour {

    private int health = 25;
    public Text win;

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
           
            
            StartCoroutine("Die");


        }
        else
        {
            Debug.Log("TEST 13: BOSS GOT HIT PASSED");
        }
    }
    /**
   * defines enemy death
   * @pre damage value from bullet sent enemy health to 0 or below
   * @post enemy is dead
   * @return void
   **/
    IEnumerator Die()
    {


        
       
        Destroy(gameObject);
        win.text = "You Just Won The Ganme!";
        yield return new WaitForSeconds(1);


    }



}
