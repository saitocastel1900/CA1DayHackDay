using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartCountDown : MonoBehaviour
{
    private int CountDownTime;//�J�E���g�_�E���Ɏg���֐�
    private float ReductionTime;//���炵�Ă�������

    [SerializeField]
    private Text CountDown;//�J�E���g�_�E���̃e�L�X�g

    // Start is called before the first frame update
    void Start()
    {
        ReductionTime = 4;//4�b�ɐݒ�
        GetComponent<AudioSource>().Play();//���ʉ��Đ�
    }

    // Update is called once per frame
    void Update()
    {
        ReductionTime -= Time.deltaTime;//�J�E���g�_�E��
        CountDownTime = (int)ReductionTime;//�J�E���g�_�E�����@int�^�ɕύX
        CountDown.text= CountDownTime.ToString();//���f

        if (CountDownTime <= -1)//�����J�E���g�_�E����-1�ȉ��ɂȂ�����
        {
            Destroy(this.gameObject);//�I�u�W�F�N�g��j��
        }
    }
}
