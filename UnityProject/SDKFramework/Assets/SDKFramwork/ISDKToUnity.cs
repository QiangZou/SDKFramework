namespace SDKFramework
{
    public interface ISDKToUnity
    {
        /// <summary>
        /// 登入成功.
        /// </summary>
        /// <param name="message"></param>
        void LoginSucceed(SDKMessage message);

        /// <summary>
        /// 注销成功.
        /// </summary>
        void LogoutSucceed();

        /// <summary>
        /// 其他.
        /// </summary>
        /// <param name="message"></param>
        string Other(SDKMessage message);
    }
}
