#nullable enable
using UnityEditor;
using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.InputSystem;

namespace TSKT
{
    public class CaptureMenuItem
    {
        [MenuItem("TSKT/Capture")]
        static void Save()
        {
            var dir = Path.Combine(Application.persistentDataPath, "Capture");
            Directory.CreateDirectory(dir);

            var now = System.DateTime.Now;
            var path = Path.Combine(dir, now.ToString("yyyyMMddHHmmss") + now.Millisecond.ToString("D3") + ".png");

            ScreenCapture.CaptureScreenshot(path);

            Application.OpenURL(dir);
            Debug.Log($"screenshot saved at {path}");
        }
    }
}
