using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameMaster : MonoBehaviour
{
    [SerializeField] GameObject textObject = null;
    int score = 0;

    void Start()
    {
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
    }

}
