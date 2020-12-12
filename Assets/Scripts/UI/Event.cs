using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Event : MonoBehaviour
{
    public Text EventText;

    public ObjectLines Dialog1;
    public ObjectLines Dialog2;
    public ObjectLines Dialog3;

    public GameObject DialogPanel;

    string[] ChapterName = { "Chapter1. 존재", "Chapter2. 사인", "Chapter3. 실종" };
    int Chapter;
    float Speed = 0.1f;

    private void Start()
    {
        Chapter = AnswerNote.Chapter;

        StartCoroutine(TypingLine());
    }

    public IEnumerator TypingLine()
    {
        for (int i = ChapterName[Chapter - 2].Length - 1; i > 0; i--)
        {
            EventText.text = ChapterName[Chapter - 2].Substring(0, i + 1);
            yield return new WaitForSeconds(Speed);
        }

        for (int i = 0; i < ChapterName[Chapter - 1].Length; i++)
        {
            EventText.text = ChapterName[Chapter - 1].Substring(0, i + 1);
            yield return new WaitForSeconds(Speed);
        }

        StartCoroutine(DialogPlay());
    }

    public IEnumerator DialogPlay()
    {
        yield return null;

        if (!DialogManager.Talking)
        {
            DialogManager.Talking = true;
            if (Chapter == 2)
                DialogPanel.GetComponent<DialogManager>().StartDialog(Dialog1);
            if (Chapter == 3)
                DialogPanel.GetComponent<DialogManager>().StartDialog(Dialog2);
            if (Chapter == 4)
                DialogPanel.GetComponent<DialogManager>().StartDialog(Dialog3);
        }
    }

    public void EventClearBtnClicked()
    {
        SceneManager.UnloadSceneAsync("EventScene");
    }
}
