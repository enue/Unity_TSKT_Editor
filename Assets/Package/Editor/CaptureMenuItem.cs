#nullable enable
using UnityEditor;
using UnityEngine;
using System.IO;

namespace TSKT
{
    public class CaptureMenuItem
    {
        [MenuItem("TSKT/Capture GameView")]
        static void Save()
        {
            var path = GeneratePath(out var dir);

            ScreenCapture.CaptureScreenshot(path);

            Application.OpenURL(dir);
            Debug.Log($"saved {path}");
        }

        [MenuItem("TSKT/Capture SceneView")]
        static void CaptureSceneView()
        {
            var camera = SceneView.lastActiveSceneView.camera;
            var renderTexture = camera.targetTexture;
            var rect = new Rect(0, 0, renderTexture.width, renderTexture.height);
            var screenShot = new Texture2D(renderTexture.width, renderTexture.height, TextureFormat.RGBA32, false);

            camera.Render();
            var original = RenderTexture.active;
            RenderTexture.active = renderTexture;
            screenShot.ReadPixels(rect, 0, 0);
            RenderTexture.active = original;

            var bytes = screenShot.EncodeToPNG();
            var path = GeneratePath(out var dir);
            File.WriteAllBytes(path, bytes);

            Application.OpenURL(dir);
            Debug.Log($"saved {path}");
        }

        static string GeneratePath(out string directory)
        {
            var dir = Path.Combine(Application.persistentDataPath, "Capture");
            Directory.CreateDirectory(dir);

            var now = System.DateTime.Now;
            var path = Path.Combine(dir, now.ToString("yyyyMMddHHmmss") + now.Millisecond.ToString("D3") + ".png");
            directory = dir;
            return path;
        }
    }
}
