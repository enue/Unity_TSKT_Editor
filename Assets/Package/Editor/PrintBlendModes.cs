using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Linq;

namespace TSKT
{
    public class PrintBlendModes
    {
        [MenuItem("TSKT/Print BlendModes")]
        static void Print()
        {
            var builder = new System.Text.StringBuilder();
            foreach (UnityEngine.Rendering.BlendMode it in System.Enum.GetValues(typeof(UnityEngine.Rendering.BlendMode)))
            {
                builder.AppendLine(it.ToString() + " : " + (int)it);
            }
            Debug.Log(builder);
        }
    }
}
