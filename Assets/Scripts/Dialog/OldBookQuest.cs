using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldBookQuest : MonoBehaviour
{
    public GameObject OldBookPopUpPanel;

    public void OldBookPopUpCloseClicked()
    {
        OldBookPopUpPanel.SetActive(false);
    }
}
