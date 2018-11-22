using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour
{
    //create a new text for totalpoint
    public Text totalpoint;
    //point for each question
    public static int point;
    public static int point1;
    public static int point2;
    public static int point3;
    public static int point4;
    public static int totalpoint1;
    public static float GPA;


    //element in each dropdown
    List<string> questions = new List<string>() { "A is member of object B", "B is member of Object A", "Product of A and B", "None of these" };
    List<string> questions1 = new List<string>() { "Operator-&", "Operator-||", "Operator-&&", "Operator +" };
    List<string> questions2 = new List<string>() { "A Slash (/)", "A Fullstop(.)", "A Comma (,)", "A Semicolon (;)" };
    List<string> questions3 = new List<string>() { "<fiostream>", "<ifstream>", "<ofstream>", "<fstream>" };
    List<string> questions4 = new List<string>() { "thrown", "threw", "throw", "throws" };
    public Dropdown dropdown;
    public Dropdown dropdown1;
    public Dropdown dropdown2;
    public Dropdown dropdown3;
    public Dropdown dropdown4;
    // Use this for initialization
    /**
     * @pre valid questionlist
     * @post set the vaild questionlist for each question
     * @para None.
     **/
    void Start()
    {
        questionlist();
        questionlist1();
        questionlist2();
        questionlist3();
        questionlist4();
    }

    /**
     * @pre valid questionlist
     * @post add elements into the first dropdown 
     * @para None.
     **/
    void questionlist()
    {

        dropdown.AddOptions(questions);

    }

    /**
    * @pre valid questionlist
    * @post add elements into the third dropdown 
    * @para None.
    **/
    void questionlist2()
    {

        dropdown2.AddOptions(questions2);
    }

    /**
    * @pre valid questionlist
    * @post add elements into the fourth dropdown 
    * @para None.
    **/
    void questionlist3()
    {
        dropdown3.AddOptions(questions3);
    }

    /**
    * @pre valid questionlist
    * @post add elements into the fifth dropdown 
    * @para None.
    **/
    void questionlist4()
    {
        dropdown4.AddOptions(questions4); ;
    }

    /**
    * @pre valid questionlist
    * @post add elements into the second dropdown 
    * @para None.
    **/
    void questionlist1()
    {
        dropdown1.AddOptions(questions1);
    }


    /**
    * @pre valid dropdown
    * @post add elements into the first dropdown 
    * @para index of anwser(int).
    **/
    public void DropdownIndex(int index)
    {
        if (index == 1)
        {
            point = 20;
            
        }
        else
        {
            point = 0;
        }
    }


    /**
    * @pre valid dropdown
    * @post add elements into the second dropdown 
    * @para index of anwser(int).
    **/
    public void DropdownIndex1(int index)
    {
        if (index == 2)
        {
            point1 = 20;
            
        }
        else
        {
            point1 = 0;
        }
    }


    /**
    * @pre valid dropdown
    * @post add elements into the third dropdown 
    * @para index of anwser(int).
    **/
    public void DropdownIndex2(int index)
    {
        if (index == 3)
        {
            point2 = 20;
            
        }
        else
        {
            point2 = 0;
        }
    }

    /**
    * @pre valid dropdown
    * @post add elements into the fourth dropdown 
    * @para index of anwser(int).
    **/
    public void DropdownIndex3(int index)
    {
        if (index == 3)
        {
            point3 = 20;
            
        }
        else
        {
            point3 = 0;
        }
    }


    /**
    * @pre valid dropdown
    * @post add elements into the fifth dropdown 
    * @para index of anwser(int).
    **/
    public void DropdownIndex4(int index)
    {
        if (index == 2)
        {
            point4 = 20;
            
        }
        else
        {
            point4 = 0;
        }
    }


    /**
    * @pre valid point
    * @post count the totalpoint 
    * @para None.
    **/
    public void total()

    {
        totalpoint1 = point + point1 + point2 + point3 + point4;     
        GPA = totalpoint1 / 100f;
    }
    /**
     * @pre  None
     * @post update the total point
     * @para None.
     **/
    public void Update()
    {
        total();
    }
}