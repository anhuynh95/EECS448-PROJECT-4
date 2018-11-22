/** 
 * @author Team FourFour8
 * @file Stage2.cs
 * @date October 2018
 * @brief Stage2 class. This class takes charge of the properties of the Stage2.
**/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2 : MonoBehaviour {
    /**
    * @pre None.
    * @post Keep the GameObject Stage2 when change the scene because unity destroy eveything on current scene after change scenes.
    * @para None.
    **/
    public void Awake()
    {
        DontDestroyOnLoad(this);

        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }
}
