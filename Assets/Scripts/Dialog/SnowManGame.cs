using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class SnowManGame : MonoBehaviour
{
    public static bool SnowManClear = false;

    public void ButtonClicked()
    {
        SnowManClear = true;
        SceneManager.LoadScene("PlaygroundScene");
    }
}
