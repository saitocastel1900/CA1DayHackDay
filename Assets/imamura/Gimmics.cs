using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gimmics : MonoBehaviour
{
    
    public GameObject Gimmick1_Panel;
    public GameObject Gimmick2_Panel;
    public GameObject Gimmick3_Panel;
    public GameObject Gimmick6_Panel;
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

    public void Gimmick2_Start()//ギミック開始
    {
        Gimmick2_Panel.SetActive(true);//パネルを表示
        Gimmick2_Panel.GetComponent<Smartphone>().setup();//パネル表示で干渉可能になったので、ギミックのセットアップを発動

    }
    public void Gimmick3_Start()//ギミック開始
    {
        Gimmick3_Panel.SetActive(true);//パネルを表示
        Gimmick3_Panel.GetComponent<Shooting>().setup();//パネル表示で干渉可能になったので、ギミックのセットアップを発動

    }
    public void Gimmick6_Start()//ギミック開始
    {
        Gimmick6_Panel.SetActive(true);//パネルを表示
        Gimmick6_Panel.GetComponent<Hannmer>().setup();//パネル表示で干渉可能になったので、ギミックのセットアップを発動

    }

}
