using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{
    public static int point;
    Text text;
    // Start is called before the first frame update
    void Awake()
    {
        text = GetComponent<Text>();
        point = point;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Fruits Collected :" + point;
    }
}
