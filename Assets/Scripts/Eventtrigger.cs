/** 
 * @author Team FourFour8
 * @file Stage4.cs
 * @date October 2018
 * @brief Stage4 class. This class takes charge of the properties of the Stage4.
**/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Eventtrigger : MonoBehaviour
{
    /**
    * @pre An existing GameObject player.
    * @post Load the scene depending on the collision tag.
    * @para The objects that collide.
    **/
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Midterm")
        {
            SceneManager.LoadScene("Midterm");
            collision.isTrigger = false;//Turn off the trigger so that the user cannot go back.
        }
        else if(collision.gameObject.tag == "Tic")
        {
            SceneManager.LoadScene("Tic");
            collision.isTrigger = false;
        }
        else if (collision.gameObject.tag == "TEST")
        {
            SceneManager.LoadScene("test");
            collision.isTrigger = false;
        }
        else if (collision.gameObject.tag == "ShotGame")
        {
            SceneManager.LoadScene("EECS268");
            collision.isTrigger = false;
            gameObject.SetActive(false);
        }
    }
}
