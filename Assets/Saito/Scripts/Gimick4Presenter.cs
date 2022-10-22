using Cysharp.Threading.Tasks;
using UniRx;
using UnityEngine;

namespace Saito.Gimick4
{
    public class Gimick4Presenter : MonoBehaviour
    {
        [SerializeField] private Gimick4View _view;
        [SerializeField] private Gimick4Model _model;

        // Start is called before the first frame update
        private void Start()
        {
            _model.Value.Subscribe(value =>
                {
                    if (value == true)
                    {
                        _view.UpdateText("よし！");
                        //ここで音を流す
                        _view.SceneTransition().Forget();
                    }
                })
                .AddTo(this);

            _view.ObservableClickButton()
                .Subscribe(_ => _model.UpdateValue(true))
                .AddTo(this);
        }
    }
}