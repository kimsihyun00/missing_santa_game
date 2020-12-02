using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasQuest : MonoBehaviour
{
    public GameObject GasOn;
    public GameObject GasOff;

    public static bool GasClicked = false;

    private void Start()
    {
        if (GasClicked)
            GasOn.SetActive(false);
    }

    public void GasBtnClicked()
    {
        GasClicked = true;
        GasOn.SetActive(false);
        GasOff.SetActive(true);
    }
}
