using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;

public class Bridge : MonoBehaviour
{
#if UNITY_WEBGL && !UNITY_EDITOR
    [DllImport("_Internal")]
    private static extern void ShowMessage(string message);
#endif

    public InputField TextInput;
    public Text DisplayText;
    void Start()
    {
        #if !UNITY_EDITOR && UNITY_WEBGL
        WebGL.Input.captureAllKeyboardInput=false;
        #endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SendToJS()
    {
        string MessageToSend = TextInput.text;
        Debug.Log("Sending message to JavaScript: " + MessageToSend);
#if UNITY_WEBGL && !UNITY_EDITOR
        ShowMessage(MessageToSend);
#endif
    }
}
