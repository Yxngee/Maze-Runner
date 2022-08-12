using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject Key;
    public GameObject Gate;


    private void Update()
    {
        if (PlayerPrefs.GetInt("Key") == 3)
        {
            Key.SetActive(false);
            Gate.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            PlayerPrefs.SetInt("Key", PlayerPrefs.GetInt("Key") + 1);
            
        }


    }
}
