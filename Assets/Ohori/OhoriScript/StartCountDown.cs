using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartCountDown : MonoBehaviour
{
    private int CountDownTime;//カウントダウンに使う関数
    private float ReductionTime;//減らしていく時間

    [SerializeField]
    private Text CountDown;//カウントダウンのテキスト

    // Start is called before the first frame update
    void Start()
    {
        ReductionTime = 4;//4秒に設定
        GetComponent<AudioSource>().Play();//効果音再生
    }

    // Update is called once per frame
    void Update()
    {
        ReductionTime -= Time.deltaTime;//カウントダウン
        CountDownTime = (int)ReductionTime;//カウントダウンを院int型に変更
        CountDown.text= CountDownTime.ToString();//反映

        if (CountDownTime <= -1)//もしカウントダウンが-1以下になったら
        {
            Destroy(this.gameObject);//オブジェクトを破棄
        }
    }
}
