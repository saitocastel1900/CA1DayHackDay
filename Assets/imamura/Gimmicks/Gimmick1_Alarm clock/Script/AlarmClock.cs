using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmClock : MonoBehaviour
{
    [HideInInspector]
    public GameObject Gimmick1_Panel;

    public bool Gimmick1_actuation = false;
    public AudioClip Knock;
    AudioSource audioSource;
    public GameObject Hand;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Gimmick1_Panel=this.gameObject;
    }
    public void setup()//ギミック作動開始
    {
        Gimmick1_actuation =true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Gimmick1_actuation==true)
        {
            Hand.transform.position=Input.mousePosition;

        }
    }


   

    public void KnockedClick()//時計がたたかれたとき
    {
       
        //アラームを止める処理

        StartCoroutine("KnockedClick_Colutin1");
      
    }

    public IEnumerator KnockedClick_Colutin1()//時計がたたかれたとき
    {
        audioSource.PlayOneShot(Knock);
        //アラームを止める処理
        yield return new WaitForSeconds(0.63f);
        StartCoroutine("ChangeColor");
        Gimmick1_Panel.SetActive(false);
        Gimmick1_actuation=false;
    }

}
