using UnityEngine.UI;
using DG.Tweening;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

public class ButtonAnimation : MonoBehaviour
{
    private Tweener _tweener = null;

    private void Start()
    {
        this.GetComponent<Button>()
            .OnPointerEnterAsObservable().Subscribe(_ => ButtonEnterAnimation()).AddTo(this);
        
        this.GetComponent<Button>()
            .OnPointerExitAsObservable().Subscribe(_ => ButtonExitAnimation()).AddTo(this);
    }


    public void ButtonEnterAnimation()
    {
        if (_tweener != null)
        {
            _tweener.Kill();
            Debug.Log(_tweener);
            _tweener = null;
            this.transform.localScale = Vector3.one;
        }

        _tweener = this.GetComponent<Button>().transform.DOScale(
            Vector3.one * 1.1f,
            duration: 0.2f
        ).SetEase(Ease.OutExpo).SetLink(this.gameObject);

        // Down時の共通処理
        Debug.Log("Button Push");
    }

    public void ButtonExitAnimation()
    {
        if (_tweener != null)
        {
            _tweener.Kill();
            Debug.Log(_tweener);
            _tweener = null;
            this.transform.localScale = Vector3.one;
        }

        _tweener = this.GetComponent<Button>().transform.DOPunchScale(
                Vector3.one * -0.1f,
                duration: 0.2f
            )
            .SetEase(Ease.InOutCubic).SetLink(this.gameObject);

        // Up時の共通処理
        Debug.Log("Button Release");
    }
}
