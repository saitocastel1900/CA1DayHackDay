using Cysharp.Threading.Tasks;
using UniRx;
using UnityEngine;

namespace Saito.Gimick5
{
    public class Gimick5Presenter : MonoBehaviour
    {
        [SerializeField] private Gimick5View _view;
        [SerializeField] private Gimick5Model _model;
        
        // Start is called before the first frame update
        void Start()
        {
            _model.Value.Subscribe(value =>
                {
                    if (value)
                    {
                        _view.ObjectActiveUpdate();
                        //音を流す
                        _view.SceneTransition().Forget();
                    }
                }).AddTo(this);
            
            _view.ObservableClickButton()
                .Subscribe(_=> _model.UpdateValue(true)).AddTo(this);
        }
    }
}