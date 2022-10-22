using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmControl2 : MonoBehaviour
{
    [SerializeField]
    public AudioClip Tapp;
    [SerializeField]
    public bool Alarm;//アラーム
    [SerializeField]
    public bool Play;//再生の判定

    private int Interval;//インターバル

    private bool set;

    [SerializeField]
    private float AlarmTime;//アラームが鳴るまでの時間


    // Start is called before the first frame update
    void Start()
    {
        Interval = 15;
        Random.InitState(System.DateTime.Now.Second+1);//シード値を設定
        Alarm = true;
        Play = true;
        set = true;
        AlarmTime = Random.Range(5, Interval);
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.FindWithTag("CountDownTime"))//CountDownTimeというタグがあるとき
        {
            AlarmTime -= Time.deltaTime;
            if (AlarmTime < 0)
            {
                if (Play)
                {
                    AudioPlay();
                    Play = false;
                }
                if (!Alarm)
                {
                    GetComponent<AudioSource>().Stop();
                    if (set)
                    {
                        AlarmTime = Random.Range(5, Interval);
                        set = false;
                    }
                }
            }
        }
    }

    private void AudioPlay()
    {
        GetComponent<AudioSource>().Play(); //OneShot(Tapp);
    }
}
