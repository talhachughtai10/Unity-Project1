using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class energylose : MonoBehaviour
{
    public Slider HealthBar;
    public void OnTriggerEnter(Collider other)
    {
        HealthBar.value -= 15;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
