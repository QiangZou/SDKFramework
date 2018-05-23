namespace SDKFramework
{
    public class Default_SDKToUnity : ISDKToUnity
    {
        public void LoginSucceed(SDKMessage message)
        {
            if (message == null)
            {
                SDKConfig.Log("Default_SDKToUnity : LoginNotice() message == null");
                return;
            }

            SDKConfig.Log("Default_SDKToUnity : LoginNotice() UserID : " + message.UserID);

            SDKConfig.LoginGame(message.UserID);
        }

        public void LogoutSucceed()
        {
            SDKConfig.Log("Default_SDKToUnity : LogoutSucceed()");

            SDKConfig.LogoutGame();
        }

        public string Other(SDKMessage message)
        {
            SDKConfig.Log("Default_SDKToUnity : Other()");

            return "null";
        }
    }
}

