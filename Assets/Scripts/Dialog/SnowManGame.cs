using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class SnowManGame : MonoBehaviour
{
    public static bool SnowManClear = false;

    public GameObject ClearBtn;

    public ObjectLines Dialog;
    public GameObject DialogPanel;

    bool dialogPlayed = false;

    private void Start()
    {
        Dialog = this.gameObject.GetComponent<ObjectLines>();
    }

    public void ButtonClicked()
    {
        SceneManager.LoadScene("PlaygroundScene");
    }

    private void Update()
    {
        if(Hat.matched && Eyes.matched && Nose.matched && Mouth.matched && Muffler.matched
            && Buttons.matched && LeftHand.matched && RightHand.matched)
        {
            ClearBtn.SetActive(true);

            if (!dialogPlayed)
            {
                SnowManClear = true;

                if (!DialogManager.Talking)
                {
                    DialogManager.Talking = true;
                    DialogPanel.GetComponent<DialogManager>().StartDialog(Dialog);
                }
                dialogPlayed = true;
            }
        }
    }
}