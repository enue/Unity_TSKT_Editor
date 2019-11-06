using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;

namespace TSKT
{
    public class PrintResolutions
    {
        [MenuItem("TSKT/Print Resolutions")]
        static void Print()
        {
            foreach (var it in Screen.resolutions)
            {
                Debug.Log(new Vector2Int(it.width, it.height));
            }
        }
    }
}
