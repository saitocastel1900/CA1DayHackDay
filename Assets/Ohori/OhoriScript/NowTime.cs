using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NowTime : MonoBehaviour
{
    private int InGgameTimeHours;//ゲーム内の時間(時)
    private int InGgameTimeMinutes;//ゲーム内時間(分)
    private float IncrementalTime;//経過時間

    [SerializeField]
    private Text InGgameTime;//時間を表すテキスト

    // Start is called before the first frame update
    void Start()
    {
        InGgameTimeHours = 6;//6時に設定
        ZeroSetting();//0に設定
    }

    // Update is called once per frame
    void Update()
    {
        IncrementalTime += Time.deltaTime;//経過時間
        if (GameObject.FindWithTag("CountDownTime"))//CountDownTimeというタグがあるとき
        {
            ZeroSetting();//0に設定
        }
        InGgameTimeMinutes = (int)IncrementalTime;//経過時間をint型に直す
        if (InGgameTimeMinutes >= 60)//60以上の時
        {
            InGgameTimeHours += 1;//Hoursに1追加
            ZeroSetting();//0に設定
        }
        if (InGgameTimeMinutes < 10)//Minutsが10未満の時
        {
            InGgameTime.text = InGgameTimeHours + ":0" + InGgameTimeMinutes;//テキストに反映
        }
        else
        {
            InGgameTime.text = InGgameTimeHours + ":" + InGgameTimeMinutes;//テキストに反映
        }
    }

    private void ZeroSetting()//0に設定
    {
        InGgameTimeMinutes = 0;//0分に設定
        IncrementalTime = 0;//0に設定
    }
}
