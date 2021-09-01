#nullable enable
using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Linq;

namespace TSKT
{
    public class OpenPersistentDataFolder
    {
        [MenuItem("TSKT/Open PersistentDataFolder")]
        static void OpenP()
        {
            Application.OpenURL(Application.persistentDataPath);
        }
    }
}
