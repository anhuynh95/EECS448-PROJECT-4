/** 
 * @author Team FourFour8
 * @file TicTacToe.cs
 * @date October 2018
 * @brief TicTacToe class. This class takes charge of the properties of the game TicTacToe.
**/
using UnityEngine;
using System.Collections;

public class Btn_Quit : MonoBehaviour
{
 public void Quit()
    {


#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;

    #else
Application.Quit();
#endif
}
}
