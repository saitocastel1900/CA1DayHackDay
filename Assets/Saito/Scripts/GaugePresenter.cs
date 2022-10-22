using UnityEngine;
using UniRx;

namespace Saito
{
    public class GaugePresenter : MonoBehaviour
    {
        [SerializeField] private GaugeModel _model;
        [SerializeField] private GaugeView _view;

        private void Start()
        {
            //model=>view
            _model.Value
                .Subscribe(x =>
                    {
                        _view.GaugeValue = x;
                        _view.GaugeAnimation();
                    },
                    ex => Debug.LogError("OnError!"),
                    () => Debug.Log("OnCompleted!")).AddTo(this);

            //view=>model
            _view.ObserbableClickButton()
                .Select(_ => +1) //ここをこれにする Observable.Interval(TimeSpan.FromSeconds(1f))
                .Subscribe(
                    value => _model.UpdateCount(_model.Value.Value + value),//ここをvalue/90にする
                    ex => Debug.LogError("OnError!"),
                    () => Debug.Log("")).AddTo(this);
        }
    }
}