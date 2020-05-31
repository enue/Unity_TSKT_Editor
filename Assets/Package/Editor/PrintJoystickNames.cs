using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Linq;

namespace TSKT
{
    public class PrintJoystickNames
    {
        [MenuItem("TSKT/Print JoystickNames")]
        static void Print()
        {
            foreach (var name in Input.GetJoystickNames())
            {
                Debug.Log(name);
            }
        }
    }
}
