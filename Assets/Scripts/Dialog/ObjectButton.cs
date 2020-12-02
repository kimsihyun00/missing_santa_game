using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectButton : MonoBehaviour
{
    public ObjectLines Dialog;

    public GameObject DialogPanel;

    private void Start()
    {
        Dialog = this.gameObject.GetComponent<ObjectLines>();
    }

    public void ObjectBtnClicked()
    {
        if (!DialogManager.Talking)
        {
            DialogManager.Talking = true;
            DialogPanel.GetComponent<DialogManager>().StartDialog(Dialog);
        }
    }
}
