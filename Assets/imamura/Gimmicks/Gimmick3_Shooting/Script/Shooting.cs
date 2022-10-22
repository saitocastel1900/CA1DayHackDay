using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [HideInInspector]
    public GameObject Gimmick3_Panel;

    public bool Gimmick3_actuation = false;
    public AudioClip Knock;
    AudioSource audioSource;
    public GameObject Reticl;





    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Gimmick3_Panel=this.gameObject;
    }
    public void setup()//ギミック作動開始
    {
        Gimmick3_actuation =true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Gimmick3_actuation==true)
        {
           Reticl.transform.position=Input.mousePosition;

        }
    }




    public void Shoot()//時計がたたかれたとき
    {

        //アラームを止める処理
        Debug.Log("aa");
        StartCoroutine("Shoot_Colutin1");

    }

    public IEnumerator Shoot_Colutin1()//時計がたたかれたとき
    {
        audioSource.PlayOneShot(Knock);
        //アラームを止める処理
        yield return new WaitForSeconds(0.63f);

        Gimmick3_Panel.SetActive(false);
        Gimmick3_actuation=false;
    }
}
