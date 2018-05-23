using UnityEngine;
using SDKFramework;

public class test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnGUI()
    {

        float buttonWidth = Screen.width * 0.2f;

        float buttonHeight = Screen.height * 0.1f;

        float positionX = Screen.width / 2f - buttonWidth / 2f;

        if (GUI.Button(new Rect(positionX, Screen.height * 0.05f, buttonWidth, buttonHeight), "初始化"))
        {
            SDKManager.GetSingleton().IUnityToSDK.Init();

        }
        if (GUI.Button(new Rect(positionX, Screen.height * 0.25f, buttonWidth, buttonHeight), "登入"))
        {
            SDKManager.GetSingleton().IUnityToSDK.Login();

        }
        if (GUI.Button(new Rect(positionX, Screen.height * 0.45f, buttonWidth, buttonHeight), "上传数据"))
        {
            SDKMessage message =SDKConfig.GetUploadInfo();

            SDKManager.GetSingleton().IUnityToSDK.UploadInfo(message);
        }
        if (GUI.Button(new Rect(positionX, Screen.height * 0.65f, buttonWidth, buttonHeight), "支付"))
        {
            SDKMessage message = SDKConfig.GetPayInfo();
            SDKManager.GetSingleton().IUnityToSDK.Pay(message);
        }
        if (GUI.Button(new Rect(positionX, Screen.height * 0.85f, buttonWidth, buttonHeight), "补充方法"))
        {
            SDKMessage message = new SDKMessage((int)SDKMessageType.Method0);
            SDKManager.GetSingleton().IUnityToSDK.Other(message);
        }
    }
}
