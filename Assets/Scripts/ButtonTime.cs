using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ButtonTime : MonoBehaviour
{

    public List<Button> buttons;
    public List<Image> images;
    public static float timerRoom = 300f;
    public float timer = 300f;

    // Start is called before the first frame update
    void Start()
    {
        images[0].gameObject.SetActive(true);
        images[1].gameObject.SetActive(false);
        images[2].gameObject.SetActive(false);
        timer = 300f;
        timerRoom = 300f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeButtonTimer(int text)
    {
        if (text == 5)
        {
            timer = 300f;
            timerRoom = 300f;
            images[0].gameObject.SetActive(true);
            images[1].gameObject.SetActive(false);
            images[2].gameObject.SetActive(false);

        }
        else {
            if (text == 10)
            {
                timer = 600f;
                timerRoom = 600f;
                images[0].gameObject.SetActive(false);
                images[1].gameObject.SetActive(true);
                images[2].gameObject.SetActive(false);
            }
            else
            {
                timer = 900f;
                timerRoom = 900f;
                images[0].gameObject.SetActive(false);
                images[1].gameObject.SetActive(false);
                images[2].gameObject.SetActive(true);
            }
        }
    }

}
