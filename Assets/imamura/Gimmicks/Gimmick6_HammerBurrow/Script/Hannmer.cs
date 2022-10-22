using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hannmer : MonoBehaviour
{

    [HideInInspector]
    public GameObject Gimmick6_Panel;

    public bool Gimmick6_actuation = false;
    public AudioClip Knock;
    AudioSource audioSource;
    public GameObject Hand;

    public GameObject front;
    public GameObject back;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Gimmick6_Panel=this.gameObject;
    }
    public void setup()//ギミック作動開始
    {
        Gimmick6_actuation =true;
        front.SetActive(true);
        back.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Gimmick6_actuation==true)
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
       

        yield return new WaitForSeconds(0.2f);
        front.SetActive(false);
        back.SetActive(true);
        //アラームを止める処理
        yield return new WaitForSeconds(1f);

        Gimmick6_Panel.SetActive(false);
        Gimmick6_actuation=false;
    }

}
