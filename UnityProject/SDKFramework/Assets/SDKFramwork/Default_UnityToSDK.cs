namespace SDKFramework
{
    public class Default_UnityToSDK : IUnityToSDK
    {
        public void Init()
        {
            SDKConfig.Log("Default_UnityToSDK : Init()");

            SDKMessage message = new SDKMessage((int)SDKMessageType.Init);

            SDKManager.GetSingleton().UnityToSDK(message);
        }

        public void Login()
        {
            SDKConfig.Log("Default_UnityToSDK : Login()");

            SDKMessage message = new SDKMessage((int)SDKMessageType.Login);

            SDKManager.GetSingleton().UnityToSDK(message);
        }

        public void Logout()
        {
            SDKConfig.Log("Default_UnityToSDK : Logout()");

            SDKMessage message = new SDKMessage((int)SDKMessageType.Logout);

            SDKManager.GetSingleton().UnityToSDK(message);
        }

        public void UploadInfo(SDKMessage message)
        {
            SDKConfig.Log("Default_UnityToSDK : UploadInfo()");

            if (message == null)
            {
                message = new SDKMessage((int)SDKMessageType.UploadInfo);
            }

            SDKManager.GetSingleton().UnityToSDK(message);
        }

        public void Pay(SDKMessage message)
        {
            SDKConfig.Log("Default_UnityToSDK : Pay()");

            if (message == null)
            {
                message = new SDKMessage((int)SDKMessageType.Pay);
            }

            SDKManager.GetSingleton().UnityToSDK(message);
        }

        public string Other(SDKMessage message)
        {
            SDKConfig.Log("Default_UnityToSDK : Other()");

            if (message == null)
            {
                message = new SDKMessage((int)SDKMessageType.Method0);
            }

            return SDKManager.GetSingleton().UnityToSDK(message);
        }
    }
}