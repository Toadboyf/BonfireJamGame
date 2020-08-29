using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhoneScript : MonoBehaviour
{

    public float batteryLife;
    public Color redColor;
    public Slider batterySlide;
    public Image fillImage;
    public Animator anim;
    public Light lightSource;
    public bool phoneDown = true;
    // Start is called before the first frame update
    void Awake()
    {
        anim.GetComponent<Animator>();
        batterySlide.maxValue = batteryLife;
    }

    // Update is called once per frame
    void Update()
    {
        batterySlide.value = batteryLife;
        if(!phoneDown)
        {
            batteryLife -= Time.deltaTime;
            if(batteryLife < 20 && fillImage.color != redColor)
            {
                fillImage.color = redColor;
            }
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            MovePhone();
        }
    }

    void MovePhone()
    {
        if(anim.GetCurrentAnimatorStateInfo(0).IsName("movePhoneUp") || anim.GetCurrentAnimatorStateInfo(0).IsName("movePhoneDown"))
        {

        }
        else
        {
            if(phoneDown)
            {
                //Bring phone up
                anim.SetTrigger("moveUp");
                lightSource.enabled = true;
                batterySlide.gameObject.SetActive(true);
                phoneDown = false;
            }
            else
            {
                anim.SetTrigger("moveDown");
                lightSource.enabled = false;
                batterySlide.gameObject.SetActive(false);
                phoneDown = true;
                
            }
        }
    }
}
