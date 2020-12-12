using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PotionGame : MonoBehaviour
{
    public static bool PotionClear = false;

    public ObjectLines Dialog;
    public GameObject DialogPanel;

    bool dialogPlayed = false;

    private void Start()
    {
        Dialog = this.gameObject.GetComponent<ObjectLines>();
    }

    private void Update()
    {
        if (PotionClear && !dialogPlayed)
        {
            if (!DialogManager.Talking)
            {
                DialogManager.Talking = true;
                DialogPanel.GetComponent<DialogManager>().StartDialog(Dialog);
            }
            dialogPlayed = true;
        }
    }

    public void ButtonClicked()
    {
        Map.PlayerPlace = (int)Places.WITCH_HOUSE;
        SceneManager.LoadScene("WitchHouseOutScene");
    }

    public void AgainBtnClicked()
    {
        SceneManager.LoadScene("PotionGameScene");
    }

}
