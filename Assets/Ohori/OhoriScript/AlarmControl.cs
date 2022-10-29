using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AlarmControl : MonoBehaviour
{
    private bool[] OpenGimmick;
    [SerializeField]
    public bool[] Alarm;//アラーム
    [SerializeField]
    public bool[] Play;//再生の判定

    private int Interval;//インターバル

    private bool[] set;

    [SerializeField]
    private float[] AlarmTime;//アラームが鳴るまでの時間

    public int NumberOfAlarms = 6;//アラームの個数

    public GameObject Gimmick1_Panel;
    public GameObject Gimmick2_Panel;
    public GameObject Gimmick3_Panel;
    //public GameObject Gimmick4_Panel;
    //public GameObject Gimmick5_Panel;
    public GameObject Gimmick6_Panel;

    // Start is called before the first frame update
    void Start()
    {
        Interval=15;
        Random.InitState(System.DateTime.Now.Second);//シード値を設定
        OpenGimmick=new bool[NumberOfAlarms];
        Alarm = new bool[NumberOfAlarms];
        Play = new bool[NumberOfAlarms];
        set = new bool[NumberOfAlarms];
        AlarmTime = new float[6];//Random.Range(5, Interval);
        for (int i = 0; i < NumberOfAlarms; i++)
        {
            OpenGimmick[i]=false;
            Alarm[i] = true;
            Play[i] = false;
            set[i] = true;
            AlarmTime[i] = 5 + 20 * i;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.FindWithTag("CountDownTime"))//CountDownTimeというタグがあるとき
        {
            for (int i = 0; i < NumberOfAlarms; i++)
            {
                AlarmTime[i] -= Time.deltaTime;
                if (AlarmTime[i] < 0)
                {
                    Play[i] = true;
                    AlarmTime[i] = 300;
                }
                if (Gimmick1_Panel.activeSelf)
                {
                    OpenGimmick[0] = true;
                }
                if (Gimmick2_Panel.activeSelf)
                {
                    OpenGimmick[1] = true;
                }
                if (Gimmick3_Panel.activeSelf)
                {
                    OpenGimmick[2] = true;
                }
                /*if (Gimmick4_Panel.activeSelf)
                {
                    OpenGimmick[3] = true;
                }
                if (Gimmick5_Panel.activeSelf)
                {
                    OpenGimmick[4] = true;
                }*/
                if (!Gimmick6_Panel.activeSelf)
                {
                    OpenGimmick[5] = false;
                }


                if (OpenGimmick[i])
                {
                    if (!Gimmick1_Panel.activeSelf)
                    {
                        Alarm[0] = false;
                        OpenGimmick[0] = false;
                    }
                    if (!Gimmick2_Panel.activeSelf)
                    {
                        Alarm[1] = false;
                        OpenGimmick[1] = false;
                    }
                    if (!Gimmick3_Panel.activeSelf)
                    {
                        Alarm[2] = false;
                        OpenGimmick[2] = false;
                    }
                    /*if (!Gimmick4_Panel.activeSelf)
                    {
                        Alarm[3] = true;
                        OpenGimmick[3] = false;
                    }
                    if (!Gimmick5_Panel.activeSelf)
                    {
                        Alarm[4] = true;
                        OpenGimmick[4] = false;
                    }*/
                    if (!Gimmick6_Panel.activeSelf)
                    {
                        Alarm[5] = false;
                        OpenGimmick[5] = false;
                    }
                }
            }
        }
    }
}
