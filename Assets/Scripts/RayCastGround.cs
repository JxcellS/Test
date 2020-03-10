using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastGround : MonoBehaviour
{
    [SerializeField] GameObject castRayFromPos = null;
    [SerializeField] float maxDistancefromGround = 0.1f;
    bool hasFallen = false;

    void Start()
    {
        hasFallen = false;
    }

    void Update()
    {
        CastRay();
    }

    void CastRay()
    {
        if (hasFallen == false)
        {
            RaycastHit hit;
            //Debug.DrawRay(castRayFromPos.transform.position, castRayFromPos.transform.TransformDirection(Vector3.down * maxDistancefromGround), Color.yellow);
            Physics.Raycast(castRayFromPos.transform.position, castRayFromPos.transform.TransformDirection(Vector3.down), out hit, maxDistancefromGround * 10f);
            if (hit.distance >= maxDistancefromGround)
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
