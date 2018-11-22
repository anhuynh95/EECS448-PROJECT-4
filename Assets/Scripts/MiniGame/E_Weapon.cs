/**
 * @author Team FourFour8
 * @file Weapon.cs
 * @date 10/2018
 * @brief defines weapon and its uses
 **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * weapon that shoots bullet objects
**/
public class E_Weapon : MonoBehaviour
{

    public Transform fireStart;
    public GameObject bulletPrep;
    private int frame = 0;
    public Animator animator;


    /**
     * update is called once per frame
     * @pre none
     * @post updated frame
     * @return void
     **/
    void Update()
    {
        animator.SetInteger("ShootFrame", frame);
        if(frame < 100)
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
