using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleDown : MonoBehaviour
{
    [SerializeField] GameObject angleFromPos = null;
    [SerializeField] float angleThreshold = 15;
    bool hasFallen = false;

    void Start()
    {
        hasFallen = false;
    }

    void Update()
    {
        CalculateAngle();
    }

    void CalculateAngle()
    {
        if (hasFallen == false)
        {
            float angle = Vector3.Angle(angleFromPos.transform.TransformDirection(Vector3.down), Vector3.down);
            if (angle > angleThreshold)
            {
                UpdateGMScore();
                hasFallen = true;
            }
        }
    }

    void UpdateGMScore()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<GameMaster>().UpdateScore();
    }
}
