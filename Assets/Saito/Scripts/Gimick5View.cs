using System;
using Cysharp.Threading.Tasks;
using UnityEngine.UI;
using UnityEngine;
using UniRx;

namespace Saito.Gimick5
{
    public class Gimick5View : MonoBehaviour
    {
        [SerializeField] private GameObject _onTelephone;    
        [SerializeField] private GameObject _offTelephone;  
        [SerializeField] private GameObject _receiver;

        [SerializeField] private GameObject _gimick5;
        
        public IObservable<Unit> ObservableClickButton()
        {
            return _onTelephone.GetComponent<Button>().OnClickAsObservable();
        }
        
        public void ObjectActiveUpdate()
        {
           _onTelephone.SetActive(false);
           _offTelephone.SetActive(true);
           _receiver.SetActive(true);
        }

        public async UniTask SceneTransition()
        {
            await UniTask.Delay(TimeSpan.FromMilliseconds(5f),cancellationToken:this.gameObject.GetCancellationTokenOnDestroy());
            _gimick5.gameObject.SetActive(false);
        }
    }
}