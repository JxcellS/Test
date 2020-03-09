using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameMaster : MonoBehaviour
{
    [SerializeField] GameObject textObject = null;
    [SerializeField] GameObject textObjectWinner = null;
    [SerializeField] string winMessage = "You are a Winner!";
    int score = 0;

    void Start()
    {
        textObjectWinner.GetComponent<TextMeshProUGUI>().text = "";
        UpdateText();
        MouseCursor();
    }

    void MouseCursor()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void UpdateScore()
    {
        score += 1;
        UpdateText();
    }

    void UpdateText()
    {
        textObject.GetComponent<TextMeshProUGUI>().text = "Punktzahl: " + score.ToString();
        if (score == 10)
        {
            textObjectWinner.GetComponent<TextMeshProUGUI>().text = winMessage;
        }
    }

}
