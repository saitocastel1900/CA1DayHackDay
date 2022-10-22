using UnityEngine;
using DG.Tweening;

namespace Saito
{
    public class ImageScaleUpLoop : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            ScaleUpAnimation();
        }

        private void ScaleUpAnimation()
        {
            var obj = this.gameObject.transform;
            //DOTween.Sequence().Append().SetEase(Ease.Linear).SetLink(this.gameObject).SetLoops(-1,LoopType.Yoyo);
        }
    }
}