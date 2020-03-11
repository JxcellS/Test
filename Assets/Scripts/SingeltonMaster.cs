using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingeltonMaster : MonoBehaviour
{
    [SerializeField] private string inputExample = "Fire1";
    public string InputExample { get { return inputExample; } }

    #region Singleton

    public static SingeltonMaster instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of " + name + " found!");
            return;
        }
        instance = this;
    }

    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
