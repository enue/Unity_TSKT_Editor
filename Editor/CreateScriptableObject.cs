using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;

namespace TSKT
{
    public class CreateScriptableObject
    {
        readonly static string[] labels = { "Data", "ScriptableObject" };

        [MenuItem("Assets/Create ScriptableObject")]
        static void Create()
        {
            foreach (Object selectedObject in Selection.objects)
            {
                var script = selectedObject as MonoScript;
                string path = EditorUtil.GenerateUniqueAssetPath(selectedObject, "asset");
                var obj = ScriptableObject.CreateInstance(script.GetClass());
                AssetDatabase.CreateAsset(obj, path);
                AssetDatabase.SetLabels(obj, labels);
                EditorUtility.SetDirty(obj);
            }
        }
    }
}
