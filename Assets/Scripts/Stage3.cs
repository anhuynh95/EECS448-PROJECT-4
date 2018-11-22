/** 
 * @author Team FourFour8
 * @file Stage3.cs
 * @date October 2018
 * @brief Stage3 class. This class takes charge of the properties of the Stage3.
**/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3 : MonoBehaviour {
    /**
    * @pre None.
    * @post Keep the GameObject Stage3 when change the scene because unity destroy eveything on current scene after change scenes.
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
