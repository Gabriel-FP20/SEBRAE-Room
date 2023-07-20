using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Goals : MonoBehaviour
{

    public List<Button> buttons;
    public List<TextMeshProUGUI> goals;
    public List<Image> images;

    public float timerFixed = 10.0f;
    public float timerChange;
    public int i;

    public Button stopButton;
    public bool stop;
    public Image imagesStop;
    // Start is called before the first frame update
    void Start()
    {
        stop = false;
        i = 0;
        timerChange = timerFixed;
        buttons[i].onClick.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        if (stop == false )
        {
            timerChange -= Time.deltaTime;
            if(timerChange < 0)
            {
                ChangeButton();
            }
        }
        
    }

    void ChangeButton()
    {
        i++;
        if(i > 2)
        {
            i = 0;
        }
        buttons[i].onClick.Invoke();
        timerChange = timerFixed;
    }

    public void ChangeText()
    {
        if (i != 0){
            goals[i].gameObject.SetActive(true);
            images[i].gameObject.SetActive(true);
            images[i-1].gameObject.SetActive(false);
            goals[i-1].gameObject.SetActive(false);
        }
        else
        {
            goals[i].gameObject.SetActive(true);
            goals[2].gameObject.SetActive(false);
            images[i].gameObject.SetActive(true);
            images[2].gameObject.SetActive(false);
        }

    }

    public void StopTimer()
    {
        stop = !stop;
        if (stop == true)
            imagesStop.gameObject.SetActive(true);
        else
            imagesStop.gameObject.SetActive(false);

    }
}
