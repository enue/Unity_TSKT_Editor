using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;

namespace TSKT
{
    public static class EditorUtil
    {
        static public string GenerateUniqueAssetPath(Object selectedObject, string extension)
        {
            string objectName = selectedObject.name;
            string dirPath = Path.GetDirectoryName(AssetDatabase.GetAssetPath(selectedObject));
            string path = string.Format("{0}/{1}." + extension, dirPath, objectName);
            return AssetDatabase.GenerateUniqueAssetPath(path);
        }
    }

}
