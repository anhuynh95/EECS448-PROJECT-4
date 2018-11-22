using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Weapon : MonoBehaviour {


    public Transform fireStart;
    public GameObject bulletPrep;
    private int frame = 0;
    //public Animator animator;


    /**
     * update is called once per frame
     * @pre none
     * @post updated frame
     * @return void
     **/
    void Update()
    {
        //animator.SetInteger("ShootFrame", frame);
        if (frame < 20)
        {
            frame++;
        }
        else
        {
            frame = 0;
            Shoot();
        }
    }
    /**
     * called on user interaction to shoot
     * @pre none
     * @post bullet is fired
     * @return void
     **/
    void Shoot()
    {
        Instantiate(bulletPrep, fireStart.position, fireStart.rotation);
    }
}
