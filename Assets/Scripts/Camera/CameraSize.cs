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
            var screenRatio = (float)Screen.width / Screen.height;
            const float targetRadio = TargetSizeX / TargetSizeY;

            if (screenRatio >= targetRadio)
            {
                Resize();
            }
            else
            {
                var differentSize = targetRadio / screenRatio;
                Resize(differentSize);
            }
        }

        private static void Resize(float differentSize = 1.0f)
        {
            if (UnityEngine.Camera.main != null)
                UnityEngine.Camera.main.orthographicSize = TargetSizeY / HalfSize * differentSize;
        }
    }
}
