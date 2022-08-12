using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Complete : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (PlayerPrefs.GetInt("Key") >= 3) 
            {
                
                SceneManager.LoadScene("Complete");
            }
            else
            {
                return;
            }
         

        }
    }
}
