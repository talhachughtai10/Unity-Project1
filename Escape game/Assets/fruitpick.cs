using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fruitpick : MonoBehaviour
{
    public bool exit = true;
    private int maxft = 1;
    static int currentft = 1;
    private int remft;
    [SerializeField]
    private AudioClip _audio;

    public int pointvalue = 1;

    public Slider healthbar;


    private void OnTriggerEnter(Collider other)
    {
        healthbar.value += 1;
        points.point += pointvalue;
        AudioSource.PlayClipAtPoint(_audio, transform.position, 1f);

        Destroy(this.gameObject);

      
    }
}
