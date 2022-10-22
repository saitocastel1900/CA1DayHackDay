using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NowTime : MonoBehaviour
{
    private int InGgameTimeHours;//�Q�[�����̎���(��)
    private int InGgameTimeMinutes;//�Q�[��������(��)
    private float IncrementalTime;//�o�ߎ���

    [SerializeField]
    private Text InGgameTime;//���Ԃ�\���e�L�X�g

    // Start is called before the first frame update
    void Start()
    {
        InGgameTimeHours = 6;//6���ɐݒ�
        ZeroSetting();//0�ɐݒ�
    }

    // Update is called once per frame
    void Update()
    {
        IncrementalTime += Time.deltaTime;//�o�ߎ���
        if (GameObject.FindWithTag("CountDownTime"))//CountDownTime�Ƃ����^�O������Ƃ�
        {
            ZeroSetting();//0�ɐݒ�
        }
        InGgameTimeMinutes = (int)IncrementalTime;//�o�ߎ��Ԃ�int�^�ɒ���
        if (InGgameTimeMinutes >= 60)//60�ȏ�̎�
        {
            InGgameTimeHours += 1;//Hours��1�ǉ�
            ZeroSetting();//0�ɐݒ�
        }
        if (InGgameTimeMinutes < 10)//Minuts��10�����̎�
        {
            InGgameTime.text = InGgameTimeHours + ":0" + InGgameTimeMinutes;//�e�L�X�g�ɔ��f
        }
        else
        {
            InGgameTime.text = InGgameTimeHours + ":" + InGgameTimeMinutes;//�e�L�X�g�ɔ��f
        }
    }

    private void ZeroSetting()//0�ɐݒ�
    {
        InGgameTimeMinutes = 0;//0���ɐݒ�
        IncrementalTime = 0;//0�ɐݒ�
    }
}
