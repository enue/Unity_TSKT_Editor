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
            return GenerateUniqueAssetPath(dirPath, objectName, extension);
        }

        static public string GenerateUniqueAssetPath(string directory, string filename, string extension)
        {
            var path = Path.Combine(directory, filename + "." + extension);
            return AssetDatabase.GenerateUniqueAssetPath(path);
        }
    }

}
