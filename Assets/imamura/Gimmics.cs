using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gimmics : MonoBehaviour
{
    
    public GameObject Gimmick1_Panel;
    public GameObject Gimmick2_Panel;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }




    public void Gimmick1_Start()//�M�~�b�N�J�n
    {
        Gimmick1_Panel.SetActive(true);//�p�l����\��
        Gimmick1_Panel.GetComponent<AlarmClock>().setup();//�p�l���\���Ŋ��\�ɂȂ����̂ŁA�M�~�b�N�̃Z�b�g�A�b�v�𔭓�

    }

    public void Gimmick2_Start()//�M�~�b�N�J�n
    {
        Gimmick2_Panel.SetActive(true);//�p�l����\��
        Gimmick2_Panel.GetComponent<Smartphone>().setup();//�p�l���\���Ŋ��\�ɂȂ����̂ŁA�M�~�b�N�̃Z�b�g�A�b�v�𔭓�

    }


}
