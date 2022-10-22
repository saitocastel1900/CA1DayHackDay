using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Saito.Title
{
    public class CreditView : MonoBehaviour
    {
        //button
        [SerializeField] private Button _openButton;
        [SerializeField] private Button closeButton;

        //credit
        [SerializeField] private GameObject _credit;

        // Start is called before the first frame update
        void Start()
        {
            _openButton.OnClickAsObservable()
                .Subscribe(value => { _credit.gameObject.SetActive(true); }).AddTo(this);
            closeButton.OnClickAsObservable()
                .Subscribe(value => { _credit.gameObject.SetActive(false); }).AddTo(this);
        }
    }
}