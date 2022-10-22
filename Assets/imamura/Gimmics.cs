using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gimmics : MonoBehaviour
{
    
    public GameObject Gimmick1_Panel;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }




    public void Gimmick1_Start()//ギミック開始
    {
        Gimmick1_Panel.SetActive(true);//パネルを表示
        Gimmick1_Panel.GetComponent<AlarmClock>().setup();//パネル表示で干渉可能になったので、ギミックのセットアップを発動

    }



}
