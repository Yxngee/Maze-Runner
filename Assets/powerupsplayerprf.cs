using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupsplayerprf : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void flyingnow()
    {
        PlayerPrefs.SetInt("flying", 1);
       // Invoke("flyingmodechange", 10);
    }
    public void flyingmodechange()
    {
       // PlayerPrefs.SetInt("flying", 0);
    }
}
