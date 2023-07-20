using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class RoomConfig : MonoBehaviour
{
    public TextMeshProUGUI timer;
    float tempoRestante; // 5 minutos em segundos

    // Start is called before the first frame update
    void Start()
    {
        tempoRestante = ButtonTime.timerRoom;
    }

    // Update is called once per frame
    void Update()
    {
        tempoRestante -= Time.deltaTime;
        ShowTime();
    }

    void ShowTime()
    {
        int minutos = Mathf.FloorToInt(tempoRestante / 60f);
        int segundos = Mathf.FloorToInt(tempoRestante % 60f);

        timer.text = minutos.ToString("00") + " : " + segundos.ToString("00");
    }
}
