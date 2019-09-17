using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerdetecthit : MonoBehaviour
{
    public Slider healthbar;
    Animator anim;
    public GameObject lose,back;
    private void OnTriggerEnter(Collider other)
    {
        anim.SetInteger("condition", 4);
        healthbar.value -= 2;
        if (healthbar.value <= 0)
        {
            anim.SetBool("dead", true);
            anim.SetBool("running", false);
            anim.SetInteger("condition", 0);
            lose.SetActive(true);
            back.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        anim.SetInteger("condition", 0);
    }


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
