using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;

namespace Saito.Common
{
    public class AddressableSceneTransitin : MonoBehaviour
    {
        [SerializeField] private AssetReference _scene;

        public async void SceneTransition()
        {
            await _scene.LoadSceneAsync(LoadSceneMode.Single).Task;
            //_scene.ReleaseAsset();
        }

        void OnDisable()
        {
            //_scene?.ReleaseAsset();
            Debug.Log("OnDisable");
        }

        private void Start()
        {
            this.gameObject.GetComponent<Button>().OnClickAsObservable()
                .Subscribe(_ => SceneTransition()).AddTo(this);
        }
    }
}