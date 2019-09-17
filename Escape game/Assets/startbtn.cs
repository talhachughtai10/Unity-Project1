using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startbtn : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
     

    }
    public void changemenuscene(string scenename)
    {
       
        Application.LoadLevel(scenename);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
