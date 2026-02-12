using UnityEngine;
using UnityEngine.UI;

public class BackgroundChanger : MonoBehaviour
{
    public GameObject overlayImage;

    public void ShowOverlay()
    {
        if (overlayImage != null)
        {
            // Делаем объект видимым
            overlayImage.SetActive(true);
        }
    }

    // Дополнительно: метод, чтобы закрыть картинку
    public void HideOverlay()
    {
        if (overlayImage != null)
        {
            overlayImage.SetActive(false);
        }
    }
}