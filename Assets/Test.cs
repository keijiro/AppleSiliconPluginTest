using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

sealed class Test : MonoBehaviour
{
    [DllImport("UniversalUnityPluginTest")]
    static extern uint UniversalUnityPluginTest_TestFunction(uint x);

    void Start()
    {
        var x = 1234U;
        var res = UniversalUnityPluginTest_TestFunction(x);
        Debug.Log($"Result: {res}");
        Debug.Log($"Expected: {x ^ 0xdeadbeefU}");
    }
}
