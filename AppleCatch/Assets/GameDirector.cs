using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;            // TextMeshPro 사용하기 위해 추가

public class GameDirector : MonoBehaviour
{
    GameObject timerText;
    TMP_Text timerTMP;      // TextMeshPro는 Text 컴포넌트와 다르다.

    GameObject pointText;
    TMP_Text pointTMP;

    float time = 60.0f;
    int point = 0;

    public void GetApple()
    {
        this.point += 100;
    }

    public void GetBomb()
    {
        this.point /= 2;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.timerText = GameObject.Find("Time");
        this.timerTMP = timerText.GetComponent<TextMeshProUGUI>();

        this.pointText = GameObject.Find("Point");
        this.pointTMP = pointText.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        this.time -= Time.deltaTime;
        //this.TimerText.GetComponent<Text>().text = this.time.ToString("F1");
        Debug.Log("Time: " + this.time.ToString("F1"));
        this.timerTMP.text = this.time.ToString("F1");

        this.pointTMP.text = this.point.ToString() + " point";
    }
}
