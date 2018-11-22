/** 
 * @author Team FourFour8
 * @file GOBACK.cs
 * @date October 2018
 * @brief GOBACK class. This class takes charge of the properties of the GOBACK.
**/
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GOBACK : MonoBehaviour
{
    public Button bt;
    /**
    * @pre None.
    * @post Begin to monitor on the TaskOnClick() function.
    * @para The objects that collide.
    **/
    void Start()
    {
        bt.onClick.AddListener(TaskOnClick);
    }
    /**
    * @pre None.
    * @post Load the scene depending on the collision tag.
    * @para The objects that collide.
    **/
    void TaskOnClick()
    {
        SceneManager.LoadScene("base");
    }
}