using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    public AudioClip Tapp;
    [SerializeField]
    public bool Alarm;//アラーム
    [SerializeField]
    public bool Play;//再生の判定

    private int Interval;//インターバル


    [SerializeField]
    private float AlarmTime;//アラームが鳴るまでの時間


    // Start is called before the first frame update
    void Start()
    {
        Interval = 15;
        Alarm = true;
        Play = true;
        set = true;
        AlarmTime = 170;
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
                }
            }
        }
    }

    private void AudioPlay()
    {
        GetComponent<AudioSource>().Play(); //OneShot(Tapp);
    }
}
