using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkullGame : MonoBehaviour
{
    public static bool SkullClear = false;

    public void ButtonClicked()
    {
        SceneManager.LoadScene("SkullSwampScene");
    }

    public void AgainBtnClicked()
    {
        SceneManager.LoadScene("SkullGameScene");
    }

}
