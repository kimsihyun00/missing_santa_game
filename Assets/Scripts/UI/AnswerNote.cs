﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerNote : MonoBehaviour
{
    // Answer Note Panel Handle
    public GameObject[] Pages = new GameObject[4];

    public GameObject LeftButton;
    public GameObject RightButton;

    public GameObject Chapter2Lock;
    public GameObject Chapter3Lock;
    
    public static int Chapter = 3;

    public GameObject[] ScrollBars = new GameObject[10];
    int[] ScrollValues = new int[10];

    public void RightBtnClicked()
    {
        LeftButton.SetActive(true);
        RightButton.SetActive(false);
        Pages[0].SetActive(false);
        Pages[1].SetActive(false);
        Pages[2].SetActive(true);
        Pages[3].SetActive(true);
        
        switch(Chapter)
        {
            case 1:
                Chapter2Lock.SetActive(true);
                Chapter3Lock.SetActive(true);
                break;
            case 2:
                Chapter2Lock.SetActive(false);
                Chapter3Lock.SetActive(true);
                break;
            case 3:
                Chapter2Lock.SetActive(false);
                Chapter3Lock.SetActive(false);
                break;
        }

    }

    public void LeftBtnClicked()
    {
        LeftButton.SetActive(false);
        RightButton.SetActive(true);
        Pages[0].SetActive(true);
        Pages[1].SetActive(true);
        Pages[2].SetActive(false);
        Pages[3].SetActive(false);
    }


    public void SelectBtnClicked()
    {
        
        switch(Chapter)
        {
            case 1:
                for (int i = 0; i < 4; i++)
                    ScrollValues[i] = (int)(ScrollBars[i].GetComponent<Scrollbar>().value * 10);
                if (ScrollValues[0] == 6 && ScrollValues[1] == 0 && ScrollValues[2] == 8 && ScrollValues[3] == 4)
                {
                    Chapter = 2;
                }
                break;
            case 2:
                for (int i = 4; i < 8; i++)
                    ScrollValues[i] = (int)(ScrollBars[i].GetComponent<Scrollbar>().value * 10);
                if (ScrollValues[4] == 2 && ScrollValues[5] == 0 && ScrollValues[6] == 6 && ScrollValues[7] == 8)
                {
                    Chapter = 3;
                }
                break;
            case 3:
                ScrollValues[8] = (int)(ScrollBars[8].GetComponent<Scrollbar>().value * 10);
                ScrollValues[9] = (int)(ScrollBars[9].GetComponent<Scrollbar>().value * 10);
                if (ScrollValues[8] == 4 && ScrollValues[9] == 2)
                {
                    Debug.Log("정답");
                }
                break;
        }
    }
}
