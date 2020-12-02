using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PotionGame : MonoBehaviour
{
    public static bool PotionClear = false;

    public void ButtonClicked()
    {
        PotionClear = true;
        SceneManager.LoadScene("WitchHouseInScene");
    }

}
