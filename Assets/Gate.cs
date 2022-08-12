using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public GameObject Gatee;

    void Update()
    {
        if (PlayerPrefs.GetInt("Key") == 3)
        { 
            Gatee.SetActive(true);
        }
    }
}
