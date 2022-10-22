using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmControl2 : MonoBehaviour
{
    [SerializeField]
    public AudioClip Tapp;
    [SerializeField]
    public bool Alarm;//�A���[��
    [SerializeField]
    public bool Play;//�Đ��̔���

    private int Interval;//�C���^�[�o��

    private bool set;

    [SerializeField]
    private float AlarmTime;//�A���[������܂ł̎���


    // Start is called before the first frame update
    void Start()
    {
        Interval = 15;
        Random.InitState(System.DateTime.Now.Second+1);//�V�[�h�l��ݒ�
        Alarm = true;
        Play = true;
        set = true;
        AlarmTime = Random.Range(5, Interval);
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.FindWithTag("CountDownTime"))//CountDownTime�Ƃ����^�O������Ƃ�
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
