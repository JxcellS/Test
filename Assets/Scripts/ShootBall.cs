using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShootBall : MonoBehaviour
{
    [SerializeField] GameObject ball = null;
    [SerializeField] float forceMultiplyer = 10.0f;
    [SerializeField] float shootTimer = 1;
    float currentCooldown = 0;
    float pushForce = 0;

    [SerializeField] GameObject textObject = null;
    // Update is called once per frame
    void Update()
    {
        Shoot();
        LowerTimer();
        Rotate();
        UpdateText();
    }

    void Shoot()
    {
        if (currentCooldown > 0)
        {
            return;
        }
        if (Input.GetButton("Fire1"))
        {
            pushForce += Time.deltaTime;
        }
        if (Input.GetButtonUp("Fire1"))
        {
            GameObject ballClone = Instantiate(ball, transform);
            ballClone.transform.parent = null;
            ballClone.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * pushForce * forceMultiplyer);
            currentCooldown = shootTimer;
            pushForce = 0;
        }
    }

    void LowerTimer()
    {
        if (currentCooldown > 0)
        {
            currentCooldown -= Time.deltaTime;
        }
        else
        {
            currentCooldown = 0;
        }
    }

    void Rotate()
    {
        float horizontalInput = Input.GetAxis("Mouse X");
        transform.Rotate(0, horizontalInput * 60 * Time.deltaTime, 0);
    }

    void UpdateText()
    {
        if (pushForce* forceMultiplyer <= 9000)
        {
            textObject.GetComponent<TextMeshProUGUI>().text = (pushForce * forceMultiplyer).ToString("0");
        }
        else
        {
            textObject.GetComponent<TextMeshProUGUI>().text = "IT IS OVER 9000!!!";
        }
    }
}
