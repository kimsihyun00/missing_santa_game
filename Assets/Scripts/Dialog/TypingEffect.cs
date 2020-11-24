using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypingEffect : MonoBehaviour
{
    public Text LineText;
    public float TypingSpeed = 0.2f;

    public IEnumerator TypingLine(string Line)
    {
        for(int i=0; i<Line.Length; i++)
        {
            LineText.text = Line.Substring(0, i + 1);
            yield return new WaitForSeconds(TypingSpeed);
        }
    }
}
