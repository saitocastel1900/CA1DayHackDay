using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    public AudioClip Tapp;
    [SerializeField]
    public bool Alarm;//�A���[��
    [SerializeField]
    public bool Play;//�Đ��̔���

    private int Interval;//�C���^�[�o��


    [SerializeField]
    private float AlarmTime;//�A���[������܂ł̎���


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
                }
            }
        }
    }

    private void AudioPlay()
    {
        GetComponent<AudioSource>().Play(); //OneShot(Tapp);
    }
}
