using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour

{
    [SerializeField] private Text txt_name;
    [SerializeField] private Image img_name;
    [SerializeField] private Slider Slider_;

    private bool isCoolTime = false;

    private float currentTime = 3f;
    private float delayTime = 3f;

    private void Update()
    {
        if (isCoolTime)
        {
            currentTime -= Time.deltaTime;
            img_name.fillAmount = currentTime / delayTime;
            img_name.fillAmount = currentTime;

            if(currentTime <= 0)
            {
                isCoolTime = false;
                currentTime = delayTime;
                img_name.fillAmount = currentTime;
            }
        }
    }


    public void Change()

    {
        txt_name.text = "확인되었습니다.";
        isCoolTime = true;
    }

    public void button()
    {
        Slider_.value -= 1;
    }
}