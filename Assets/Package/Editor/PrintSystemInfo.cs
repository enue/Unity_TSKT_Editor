using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Linq;

namespace TSKT
{
    public class PrintSystemInfo
    {
        [MenuItem("TSKT/Print SystemInfo")]
        static void Print()
        {
            var staticProperties = typeof(SystemInfo).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static).OrderBy(_ => _.Name);
            foreach (var property in staticProperties)
            {
                Debug.Log(property.Name + " : " + property.GetValue(null, null).ToString());
            }
        }
    }
}
