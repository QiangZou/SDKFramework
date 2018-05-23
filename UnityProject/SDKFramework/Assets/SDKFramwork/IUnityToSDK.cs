namespace SDKFramework
{
    /// <summary>
    /// 渠道接口
    /// </summary>
    public interface IUnityToSDK
    {
        /// <summary>
        /// 初始化.
        /// </summary>
        void Init();

        /// <summary>
        /// 登入.
        /// </summary>
        void Login();

        /// <summary>
        /// 注销.
        /// </summary>
        void Logout();

        /// <summary>
        /// 上传信息.
        /// </summary>
        /// <param name="message"></param>
        void UploadInfo(SDKMessage message);

        /// <summary>
        /// 支付
        /// </summary>
        /// <param name="message"></param>
        void Pay(SDKMessage message);

        /// <summary>
        /// 其他.
        /// </summary>
        /// <param name="message"></param>
        string Other(SDKMessage message);
    }
}
