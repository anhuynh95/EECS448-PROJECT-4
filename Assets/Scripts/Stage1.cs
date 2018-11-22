/** 
 * @author Team FourFour8
 * @file Stage1.cs
 * @date October 2018
 * @brief Stage1 class. This class takes charge of the properties of the Stage1.
**/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1 : MonoBehaviour {
    /**
    * @pre None.
    * @post Keep the GameObject player when change the scene because unity destroy eveything on current scene after change scenes.
    * @para None.
    **/
    void Start()
    {
        DontDestroyOnLoad(this);
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }
}
