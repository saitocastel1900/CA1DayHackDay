using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Saito
{
    public class ImageScroll : MonoBehaviour
    {
        [SerializeField] RawImage background;
        [SerializeField] private float X_SPEED = 0.04f;
        [SerializeField] private float Y_SPEED = 0.0f;

        void Start()
        {
            Observable.EveryUpdate().Subscribe(_ => Scroll()).AddTo(this);
        }

        void Scroll()
        {
            var rect = background.uvRect;
            rect.x = (rect.x + X_SPEED * Time.unscaledDeltaTime) % 1.0f;
            rect.y = (rect.y + Y_SPEED * Time.unscaledDeltaTime) % 1.0f;
            background.uvRect = rect;
        }
    }
}