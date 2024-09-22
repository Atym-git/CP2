using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timerbutton : MonoBehaviour
{
    [SerializeField] private int time;
    [SerializeField] private Image image;
    [SerializeField] private float image_fillspeed;
    [SerializeField] private Button button;

    private void Start()
    {
        button.onClick.AddListener(() => StartCoroutine(Timer()));

    }

    IEnumerator Timer()
    {
           for (int i = 0; i <= time; i++)
        {
            Image_fill();
            yield return new WaitForSeconds(1);
        }
    }    


    void OnclickButton()
    {
        

        
    }

    private void Image_fill()
    {
        if (image.fillAmount > 0)
            { image.fillAmount = image.fillAmount - image_fillspeed;

            }
        else
        {
            image.fillAmount = 1;
        }
    }    

}
