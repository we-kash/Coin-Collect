using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ID : MonoBehaviour
{
    public Text id;
    void Start()
    {
        id.text = SystemInfo.deviceUniqueIdentifier;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
