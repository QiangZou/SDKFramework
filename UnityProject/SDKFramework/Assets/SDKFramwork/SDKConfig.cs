using UnityEngine;
using System;
using Pathfinding.Serialization.JsonFx;

namespace SDKFramework
{
    public class SDKConfig
    {
        /// <summary>
        /// 根据渠道名判断是否要使用通用调用SDK类
        /// </summary>
        /// <param name="channelName">渠道名</param>
        /// <returns></returns>
        public static IUnityToSDK GetUnityToSDK(string channelName)
        {
            IUnityToSDK UnityToSDK = new Default_UnityToSDK();

            if (channelName == "XiaoMi")
            {

            }

            return UnityToSDK;
        }

        /// <summary>
        /// 根据渠道名判断是否要使用回调Unity类
        /// </summary>
        /// <param name="channelName"></param>
        /// <returns></returns>
        public static ISDKToUnity GetSDKToUinty(string channelName)
        {
            ISDKToUnity SDKToUnity = new Default_SDKToUnity();

            if (channelName == "XiaoMi")
            {

            }

            return SDKToUnity;
        }







        /// <summary>
        /// 获取上传角色相关数据;
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static SDKMessage GetUploadInfo()
        {
            SDKMessage message = new SDKMessage((int)SDKMessageType.UploadInfo);

            //在这里把你游戏中的相关信息 全部赋值
            message.RoleId = 1022222222;
            message.RoleName = "zq";
            message.RoleLevel = 199;
            message.RoleProfessionalID = 1;




            return message;
        }

        /// <summary>
        /// 获取支付相关数据;
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static SDKMessage GetPayInfo()
        {
            SDKMessage message = new SDKMessage((int)SDKMessageType.Pay);

            //在这里把你游戏中的相关信息 全部赋值
            message.Money = 10;
            message.OrderId = Guid.NewGuid().ToString("N").Substring(0, 30);
            message.ProductName = "金币";
            message.ProductDescription = "购买物品使用的金币";



            return message;
        }






        /// <summary>
        /// 登录.
        /// </summary>
        /// <param name="userID">SDK userID</param>
        public static void LoginGame(string userID)
        {
            //userID 为SDK用户ID
            //在这里做游戏登录操作


        }

        /// <summary>
        /// 注销.
        /// </summary>
        /// <param name="userID"></param>
        public static void LogoutGame()
        {

            //SDK浮标进行的注销  
            //在这里做返回登录界面的操作和再次调用SDK登录功能


        }





        /// <summary>
        /// 类转换为JSON格式的STRING.
        /// </summary>
        /// <returns>The to json.</returns>
        /// <param name="message">Message.</param>
        public static string ClassToJson(SDKMessage message)
        {

            //在这里可以替换自己工程使用的JSON插件

            return JsonWriter.Serialize(message);
        }

        /// <summary>
        /// JJSON格式的STRING转换类.
        /// </summary>
        /// <returns>The to class.</returns>
        /// <param name="message">Message.</param>
        public static SDKMessage JsonToClass(string message)
        {
            //在这里可以替换自己工程使用的JSON插件

            return JsonReader.Deserialize<SDKMessage>(message); ;
        }


        /// <summary>
        /// 打印SDKMessage信息.
        /// </summary>
        /// <param name="message">Message.</param>
        public static void ShowSDKMessageInfo(SDKMessage message)
        {
            Log("SDKConfig : ShowSDKMessageInfo Type:" + message.Type);
            Log("SDKConfig : ShowSDKMessageInfo Money:" + message.Money);
            Log("SDKConfig : ShowSDKMessageInfo OrderId:" + message.OrderId);
            Log("SDKConfig : ShowSDKMessageInfo RechargeTime:" + message.RechargeTime);
            Log("SDKConfig : ShowSDKMessageInfo ProductID:" + message.ProductID);
            Log("SDKConfig : ShowSDKMessageInfo ProductName:" + message.ProductName);
            Log("SDKConfig : ShowSDKMessageInfo ProductDescription:" + message.ProductDescription);
            Log("SDKConfig : ShowSDKMessageInfo UploadInfoType:" + message.UploadInfoType);
            Log("SDKConfig : ShowSDKMessageInfo RoleId:" + message.RoleId);
            Log("SDKConfig : ShowSDKMessageInfo RoleName:" + message.RoleName);
            Log("SDKConfig : ShowSDKMessageInfo RoleLevel:" + message.RoleLevel);
            Log("SDKConfig : ShowSDKMessageInfo RoleProfessionalID:" + message.RoleProfessionalID);
            Log("SDKConfig : ShowSDKMessageInfo RoleProfessionalName:" + message.RoleProfessionalName);
            Log("SDKConfig : ShowSDKMessageInfo RolePower:" + message.RolePower);
            Log("SDKConfig : ShowSDKMessageInfo CreateRoleTime:" + message.CreateRoleTime);
            Log("SDKConfig : ShowSDKMessageInfo RoleUpgradeTime:" + message.RoleUpgradeTime);
            Log("SDKConfig : ShowSDKMessageInfo Diamond:" + message.Diamond);
            Log("SDKConfig : ShowSDKMessageInfo AreaId:" + message.AreaId);
            Log("SDKConfig : ShowSDKMessageInfo ArenName:" + message.ArenName);
            Log("SDKConfig : ShowSDKMessageInfo VIPLevel:" + message.VIPLevel);
            Log("SDKConfig : ShowSDKMessageInfo GangID:" + message.GangID);
            Log("SDKConfig : ShowSDKMessageInfo GangName:" + message.GangName);
            Log("SDKConfig : ShowSDKMessageInfo CompanyName:" + message.CompanyName);
            Log("SDKConfig : ShowSDKMessageInfo UserID:" + message.UserID);
            Log("SDKConfig : ShowSDKMessageInfo Variable0:" + message.Variable0);
            Log("SDKConfig : ShowSDKMessageInfo Variable1:" + message.Variable1);
            Log("SDKConfig : ShowSDKMessageInfo Variable2:" + message.Variable2);
            Log("SDKConfig : ShowSDKMessageInfo Variable3:" + message.Variable3);
            Log("SDKConfig : ShowSDKMessageInfo Variable4:" + message.Variable4);
            Log("SDKConfig : ShowSDKMessageInfo Variable5:" + message.Variable5);
            Log("SDKConfig : ShowSDKMessageInfo Variable6:" + message.Variable6);
            Log("SDKConfig : ShowSDKMessageInfo Variable7:" + message.Variable7);
            Log("SDKConfig : ShowSDKMessageInfo Variable8:" + message.Variable8);
            Log("SDKConfig : ShowSDKMessageInfo Variable9:" + message.Variable9);
        }


        /// <summary>
        /// 统一控制日志.
        /// </summary>
        /// <param name="str"></param>
        public static void Log(string str)
        {
            Debug.Log("SDKConfig Log:" + str);
        }
    }
}