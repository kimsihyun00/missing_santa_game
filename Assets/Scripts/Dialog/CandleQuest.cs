using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleQuest : MonoBehaviour
{
    public GameObject CandleOn1;
    public GameObject CandleOff1;

    public GameObject CandleOn2;
    public GameObject CandleOff2;

    public static bool CandleClicked1 = false;
    public static bool CandleClicked2 = false;

    private void Start()
    {
        if (CandleClicked1)
            CandleOn1.SetActive(false);

        if (CandleClicked2)
            CandleOn2.SetActive(false);
    }

    public void Candle1BtnClicked()
    {
        CandleClicked1 = true;
        CandleOn1.SetActive(false);
        CandleOff1.SetActive(true);
    }

    public void Candle2BtnClicked()
    {
        CandleClicked2 = true;
        CandleOn2.SetActive(false);
        CandleOff2.SetActive(true);
    }

}
