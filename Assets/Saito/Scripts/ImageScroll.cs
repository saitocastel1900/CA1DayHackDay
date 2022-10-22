using UnityEngine;
using UnityEngine.UI;

public class ImageScroll : MonoBehaviour
{
    [SerializeField] RawImage background;
    [SerializeField]private  float X_SPEED = 0.04f;
    [SerializeField]private  float Y_SPEED = 0.0f;

    void Update()
    {
        var rect = background.uvRect;
        rect.x = (rect.x + X_SPEED * Time.unscaledDeltaTime) % 1.0f;
        rect.y = (rect.y + Y_SPEED * Time.unscaledDeltaTime) % 1.0f;
        background.uvRect = rect;
    }
}
