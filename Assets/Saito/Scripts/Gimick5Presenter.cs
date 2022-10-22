using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Saito.Gimick5
{
    public class Gimick5Presenter : MonoBehaviour
    {
        [SerializeField] private Gimick5View _view;
        
        // Start is called before the first frame update
        void Start()
        {
            _view.ObservableClickButton()
                .Subscribe(_=>
                {
                    _view.ObjectActiveUpdate();
                    //音を流す
                }).AddTo(this);
        }
    }
}