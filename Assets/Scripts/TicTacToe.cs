
//reference: https://blog.csdn.net/peanutdo1t/article/details/79706261; Author: PeanutDo1t
/** 
 * @author Team FourFour8
 * @file TicTacToe.cs
 * @date October 2018
 * @brief TicTacToe class. This class takes charge of the properties of the game TicTacToe.
**/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TicTacToe : MonoBehaviour
{
    private int[,] block = new int[3, 3];
    private int player = 1;
    // The computer will be -1

    // Use this for initialization
    /**
    * @pre None.
    * @post Initialize the 3*3 board;
    * @para None.
    **/
    void Start()
    {
        player = 1;
        for (int i = 0; i < 3; ++i)
        {
            for (int j = 0; j < 3; ++j)
            {
                block[i, j] = 0;
            }
        }
    }
    /**
    * @pre An existing board.
    * @post Check for the game result.
    * @para None.
    **/
    int check()
    {
        // winning case:horizontal
        for (int i = 0; i < 3; ++i)
        {
            if ((block[i, 0] != 0) && (block[i, 0] == block[i, 1]) && (block[i, 1] == block[i, 2]))
            {
                return block[i, 0];
            }
        }

        // winning case:vertical
        for (int j = 0; j < 3; ++j)
        {
            if ((block[0, j] != 0) && (block[0, j] == block[1, j]) && (block[1, j] == block[2, j]))
            {
                return block[0, j];
            }
        }

        // winning case: diagonal
        if ((block[1, 1] != 0) &&
            (block[0, 0] == block[1, 1]) && (block[1, 1] == block[2, 2]) ||
            (block[0, 2] == block[1, 1]) && (block[1, 1] == block[2, 0]))
        {
            return block[1, 1];
        }

        // checking game status: 0 means game is still on
        for (int i = 0; i < 3; ++i)
        {
            for (int j = 0; j < 3; ++j)
            {
                if (block[i, j] == 0)
                {
                    return 0;
                }
            }
        }

        // Draw:
        return 2;

    }

    //main function
    /**
    * @pre An existing board.
    * @post Allow the user to play the game.
    * @para None.
    **/
    void OnGUI()
    {
        GUIStyle fontStyle = new GUIStyle();
        fontStyle.normal.background = null;
        fontStyle.normal.textColor = new Color(1, 1, 0);
        fontStyle.fontSize = 40;

        for (int i = 0; i < 3; ++i)
        {
            for (int j = 0; j < 3; ++j)
            {
                if (block[i, j] == 1)
                {
                    GUI.Button(new Rect(300 + i * 100, 100 + j * 100, 100, 100), "O"); //create a new button for O player
                    //public Button button1;
                }
                if (block[i, j] == -1)
                {
                    GUI.Button(new Rect(300 + i * 100, 100 + j * 100, 100, 100), "X"); // create a new button for X player
                }
                if (GUI.Button(new Rect(300 + i * 100, 100 + j * 100, 100, 100), "")) //check if the block is marked
                {
                    if (check() == 0)
                    {
                        if (player == 1)
                        {
                            block[i, j] = 1;
                        }
                        else
                        {
                            block[i, j] = -1;
                        }
                        player = -player;
                    }
                }
            }
        }

        if ((player == -1) && (check() == 0)) // Computer make one step
        {
            int ri = (int)Random.Range(0, 3);
            int rj = (int)Random.Range(0, 3);

            bool left = false;
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    if (block[i, j] == 0)
                    {
                        left = true;
                    }
                }
            }

            while ((block[ri, rj] != 0) && (left == true))
            {
                ri = (int)Random.Range(0, 3);
                rj = (int)Random.Range(0, 3);
            }

            if (block[ri, rj] == 0)
            {
                block[ri, rj] = -1;
            }

            player = -player;
        }

        //GUI.Label(new Rect(100, 185, 100, 100), "Result:");
        if (check() == -1)
        {
            GUI.Label(new Rect(65, 185, 200, 200), "You lose!", fontStyle);
        }
        else if (check() == 1)
        {
            GUI.Label(new Rect(65, 185, 200, 200), "You win!", fontStyle);
        }
        else if (check() == 2)
        {
            GUI.Label(new Rect(65, 185, 200, 200), "Draw!", fontStyle);
        }
    }




}