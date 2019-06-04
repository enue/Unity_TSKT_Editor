using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Linq;

namespace TSKT
{
    public class GenerateUUID
    {
        [MenuItem("TSKT/Generate UUID")]
        static void Generate()
        {
            Debug.Log(System.Guid.NewGuid().ToString());
        }
    }
}
