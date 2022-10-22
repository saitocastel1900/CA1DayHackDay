using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Smartphone : MonoBehaviour
{
    // Start is called before the first frame update
    [HideInInspector]
    public GameObject Gimmick2_Panel;
    public GameObject SmartPhons;

    public Vector2 farst;

    public Slider Slider1;//スライダー1
    public Slider Slider2;//スライダー2

    public bool Gimmick2_actuation = false;
    public AudioClip Rugged;
    AudioSource audioSource;


    public bool Swipe1Juje = false;
    public bool Swipe2Juje = false;

    public GameObject[] PassUI;
    public Sprite[] Numbers;
    List<int> Pass= new List<int>();
    public AudioClip Tapp;
    public AudioClip Cancel;
    public AudioClip Colect;
    public AudioClip miss;
    public AudioClip release;
    public int PushNum_con;//コルーチンによるボタンへの影響の回避用

    // Start is called before the first frame update
    void Start()
    {
        farst=SmartPhons.GetComponent<RectTransform>().anchoredPosition;
        audioSource = GetComponent<AudioSource>();
        Gimmick2_Panel=this.gameObject;
    }
    public void setup()//ギミック作動開始
    {
        SmartPhons.GetComponent<RectTransform>().anchoredPosition=farst;
        Gimmick2_actuation =true;
        Pass.Clear();

        Swipe1Juje = false;
        Swipe2Juje = false;
        foreach (var obj in PassUI)
        {
            obj.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
      
    }


    public void Swipe1()
    {
        Debug.Log("AAA");
        if (Slider1.value >= 0.7&&Swipe1Juje==false)
        {
            Swipe1Juje=true;
            Debug.Log("BBB");
            StartCoroutine("Swiped");

        }
    }
    public void Swipe1break()
    {
        if (Slider1.value < 0.7&&Swipe1Juje==false)
        {
            Slider1.value=0;
        }
    }


   
    public void Swipe2()
    {
        Debug.Log("AAA");
        if (Slider2.value >= 0.7&&Swipe2Juje==false)
        {
            Swipe2Juje=true;
            Debug.Log("BBB");
            StartCoroutine("Swiped");
        }
    }
    public void Swipe2break()
    {
        if (Slider2.value < 0.7&&Swipe1Juje==false)
        {
            Slider2.value=0;
        }
    }
    public IEnumerator Swiped()
    {

        audioSource.PlayOneShot(Rugged);
        //アラームを止める処理
        yield return new WaitForSeconds(0.5f);

        var farstPosition = SmartPhons.GetComponent<RectTransform>();
        farstPosition.anchoredPosition=new Vector2(farstPosition.anchoredPosition.x, farstPosition.anchoredPosition.y+680);

    }


    public void Lock()
    {

    }


    public void PassPush(int Pushnum)
    {
        PushNum_con=Pushnum;
        StartCoroutine("PassPushCoroutin");
    }
    public void CancelPush()
    {
        
        PassUI[Pass.Count-1].SetActive(false);
        Pass.RemoveAt(Pass.Count-1);
        audioSource.PlayOneShot(Cancel);

    }

    public IEnumerator PassPushCoroutin()
    {
        audioSource.PlayOneShot(Tapp);
     
        //アラームを止める処理
        yield return new WaitForSeconds(0.15f);

        Pass.Add(PushNum_con);

        PassUI[Pass.Count-1].GetComponent<Image>().sprite=Numbers[PushNum_con];
        PassUI[Pass.Count-1].SetActive(true);
       




        if (Pass.Count>=4)
        {
            string passString = "";
            foreach (var num in Pass)
            {
                passString+=num.ToString();
            }
            if (passString=="3125")
            {

                StartCoroutine("UnLock");

                Debug.Log("EEE");
            }
            else
            {
                yield return new WaitForSeconds(0.1f);
                audioSource.PlayOneShot(miss);
                yield return new WaitForSeconds(0.3f);
                Pass.Clear();
                
                foreach(var obj in PassUI)
                {
                    obj.SetActive(false);
                }
            }

        }

    }

    public IEnumerator UnLock()
    {

        audioSource.PlayOneShot(Colect);
        yield return new WaitForSeconds(0.5f);

        var farstPosition = SmartPhons.GetComponent<RectTransform>();
        farstPosition.anchoredPosition=new Vector2(farstPosition.anchoredPosition.x, farstPosition.anchoredPosition.y+680);

    }

    public void stop()
    {
        audioSource.PlayOneShot(release);
        StartCoroutine("stopCoroutin");

    }
    public IEnumerator stopCoroutin()
    {
       
        //アラームを止める処理
        yield return new WaitForSeconds(0.5f);
       

        Gimmick2_Panel.SetActive(false);
        Gimmick2_actuation=false;

    }










     public void KnockedClick()//時計がたたかれたとき
    {

        //アラームを止める処理

        StartCoroutine("KnockedClick_Colutin1");
      

       

    }





   

}
