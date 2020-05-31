using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace TSKT
{
    public static class GetAssetPath
    {
        [MenuItem("Assets/GetAssetPath")]
        static void GetPath()
        {
            foreach (Object selectedObject in Selection.objects)
            {
                Debug.Log(AssetDatabase.GetAssetPath(selectedObject));
            }
        }
    }
}
