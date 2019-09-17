using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    
  
    public int pointvalue = 50;
    public GameObject winnertext,back;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (points.point == pointvalue)
        {
            winnertext.gameObject.SetActive(true);
            back.SetActive(true);
        }
    }
}
