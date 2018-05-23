namespace SDKFramework
{

    public enum SDKMessageType
    {
        NUll,

        GetChannelName,

        Init,
        Login,
        Logout,
        UploadInfo,
        Pay,

        LoginSucceed,
        LogoutSucceed,


        /// <summary>
        /// 补充的5个方法.
        /// </summary>
        Method0,
        Method1,
        Method2,
        Method3,
        Method4,

    }

    public class SDKMessage
    {
        public SDKMessage(int type)
        {
            Type = type;
        }


        /// <summary>
        /// 调用方法类型.
        /// </summary>
        public int Type = -1;










        /////////////////////////Unity 传递给 SDK 的数据.


        /// <summary>
        /// 价格.
        /// </summary>
        public float Money = -1f;
        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderId = string.Empty;
        /// <summary>
        /// 创建订单时间.
        /// </summary>
        public int RechargeTime = -1;
        /// <summary>
        /// 商品ID.
        /// </summary>
        public int ProductID = -1;
        /// <summary>
        /// 商品名字.
        /// </summary>
        public string ProductName = string.Empty;
        /// <summary>
        /// 商品描述.
        /// </summary>
        public string ProductDescription = string.Empty;


        /// <summary>
        /// 上传信息类型 设备激活 注册 登入 创建角色 进入游戏 升级 升级VIP 注销 退出
        /// </summary>
        public int UploadInfoType = -1;

        /// <summary>
        /// 角色ID.
        /// </summary>
        public long RoleId = -1;
        /// <summary>
        /// 角色名字.
        /// </summary>
        public string RoleName = string.Empty;
        /// <summary>
        /// 角色等级.
        /// </summary>
        public int RoleLevel = -1;
        /// <summary>
        /// 角色职业ID.
        /// </summary>
        public int RoleProfessionalID = -1;
        /// <summary>
        /// 角色职业名字.
        /// </summary>
        public string RoleProfessionalName = string.Empty;
        /// <summary>
        /// 角色战斗力.
        /// </summary>
        public int RolePower = -1;
        /// <summary>
        /// 角色创建时间.
        /// </summary>
        public string CreateRoleTime = string.Empty;
        /// <summary>
        /// 角色升级时间.
        /// </summary>
        public string RoleUpgradeTime = string.Empty;
        /// <summary>
        /// 剩余钻石.
        /// </summary>
        public int Diamond = -1;
        /// <summary>
        /// 区服ID.
        /// </summary>
        public int AreaId = -1;
        /// <summary>
        /// 区服名字.
        /// </summary>
        public string ArenName = string.Empty;
        /// <summary>
        /// VIP等级.
        /// </summary>
        public int VIPLevel = -1;
        /// <summary>
        /// 公会Id.
        /// </summary>
        public long GangID = -1;
        /// <summary>
        /// 公会名字.
        /// </summary>
        public string GangName = string.Empty;
        /// <summary>
        /// 公司名字.
        /// </summary>
        public string CompanyName = string.Empty;









        /////////////////////////SDK 传递给 Unity 的数据.








        /// <summary>
        /// 用户ID.
        /// </summary>
        public string UserID = string.Empty;
        /// <summary>
        /// Token.
        /// </summary>
        public string Token = string.Empty;


















        /////////////////////////补充的10个变量.

        public string Variable0 = string.Empty;
        public string Variable1 = string.Empty;
        public string Variable2 = string.Empty;
        public string Variable3 = string.Empty;
        public string Variable4 = string.Empty;
        public string Variable5 = string.Empty;
        public string Variable6 = string.Empty;
        public string Variable7 = string.Empty;
        public string Variable8 = string.Empty;
        public string Variable9 = string.Empty;
    }
}
