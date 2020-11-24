using System.Collections;
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

    int Chapter = 1;

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
}
