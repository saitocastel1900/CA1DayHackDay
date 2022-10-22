using System;
using UniRx;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Saito.Gimick4
{
    public class Gimick4View : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private Text _text;
        
        [SerializeField] private GameObject _gimick4;

        public IObservable<Unit> ObservableClickButton()
        {
            return _button.OnClickAsObservable();
        }

        public void UpdateText(string text)
        {
            _text.text = text;
        }
        
        /// <summary>
        /// オブジェクトのアクティブ状態を設定
        /// </summary>
        public async UniTask ObjectActiveUpdate()
        {
            await UniTask.Delay(TimeSpan.FromSeconds(2f), cancellationToken: this.GetCancellationTokenOnDestroy());
            _gimick4.SetActive(false);
        }
    }
}