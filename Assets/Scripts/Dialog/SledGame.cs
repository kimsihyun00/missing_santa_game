using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SledGame : MonoBehaviour
{
    public static bool SledClear = false;

    public void ButtonClicked()
    {
        SledClear = true;
        SceneManager.LoadScene("RudolphForestScene");
    }

}
