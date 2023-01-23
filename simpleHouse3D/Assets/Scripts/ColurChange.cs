using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ColurChange : MonoBehaviour
{

    private void changeToGreen()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(0.133f, 0.3725f, 0.3098f, 0.37f);
        //gameObject.GetComponent<Renderer>().material.color = Color.white;
    }

    private void changeToCyan()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.cyan;
    }

    private void changeToGrey()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.grey;
    }

    private void changeToMagenta()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.magenta;
    }

    public void OnDropDownChanged(int DropDownValue)
    {

        //Debug.Log("DROP DOWN CHANGED -> " + DropDownValue);
        if (DropDownValue == 0)
        {
            changeToCyan();
        }
        if (DropDownValue == 1)
        {
            changeToGreen();
        }
        if (DropDownValue == 2)
        {
            changeToGrey();
        }
        if (DropDownValue == 3)
        {
            changeToMagenta();
        }
    }


}

