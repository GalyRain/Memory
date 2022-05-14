using UnityEngine;

namespace Camera
{
    public class CameraSize : MonoBehaviour
    {
        private const float TargetSizeX = 1280.0f;
        private const float TargetSizeY = 720.0f;
        private const float HalfSize = 200.0f; // половина высоты в пикселях

        private void Awake()
        {
            CameraResize();
        }

        private static void CameraResize()
        {
            float screenRatio = (float)Screen.width / Screen.height;
            float targetRadio = TargetSizeX / TargetSizeY;

            if (screenRatio >= targetRadio)
            {
                Resize();
            }
            else
            {
                float differentSize = targetRadio / screenRatio;
                Resize(differentSize);
            }
        }

        private static void Resize(float differentSize = 1f)
        {
            if (UnityEngine.Camera.main != null)
                UnityEngine.Camera.main.orthographicSize = TargetSizeY / HalfSize * differentSize;
        }
    }
}