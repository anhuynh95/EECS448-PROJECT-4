/** 
 * @author Team FourFour8
 * @file PlayerManager.cs
 * @date October 2018
 * @brief PlayerManager class. This class takes charge of the properties of the Player.
**/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    // Update is called once per frame
    public static float Movespeed;// The move speed of the charater.
    public static float GPA;// The global 
    float i = 1;// Counter that prevent the user to move multiple times.
    private static bool playerExist;// Flag to check whether the player is existing on current screnn;
    /**
    * @pre None.
    * @post Keep the GameObject player when change the scene because unity destroy eveything on current scene after change scenes.
    * @para None.
    **/
    void Start()
    {
        if(!playerExist)
        {
            playerExist = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }


    }
    /**
    * @pre None.
    * @post Allow the user to control the player object with left and right arrow keys.
    * @para None.
    **/
    void Update ()
    {
        if (i >= 1)
        {
            if (Input.GetKey(KeyCode.RightArrow))//Move right.
            {
                gameObject.transform.position += new Vector3(20, 0, 0);//20 is the distance from one block to anouther.
                i = 0;//Reset the time counter.
            }
            if (Input.GetKey(KeyCode.LeftArrow))//Move left.
            {
                gameObject.transform.position += new Vector3(-20, 0, 0);
                i = 0;
            }
            
        }
        i += Time.deltaTime;//Counter increase.
    }
}
