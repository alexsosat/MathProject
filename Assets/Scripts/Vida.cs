using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    public Color32 startColor;
    public Color32 middleColor;
    public Color32 endColor;

    public Slider slider;
    public Image health;
    private float targetProgress = 1;

    public float fillSpeed = 0.5f;

    public Image Pimg;
    public Sprite Nimg;
    public Sprite Dimg;

    private Animator anim;

    private void Start()
    {
       // hurtPlayer(1f);
       anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (slider.value > targetProgress)
        {
            Pimg.sprite = Nimg;
            slider.value -= fillSpeed * Time.deltaTime;
            if (slider.value < 0.7f)
            {
                health.color = Color.Lerp(startColor, middleColor, 5); ;
            }
            if (slider.value < 0.3f)
            {
                health.color = Color.Lerp(middleColor, endColor, 5); ;
            }
        }
        else
        {
            Pimg.sprite = Dimg;
        }
        anim.SetFloat("HP", slider.value);
    }

    public void hurtPlayer(float nProgress)
    {
        targetProgress = slider.value - nProgress;
    }

   
    }


