////
////  SDKMessage.hpp
////  Unity-iPhone
////
////  Created by zouqiang on 2018/5/24.
////
//
//#ifndef SDKMessage_hpp
//#define SDKMessage_hpp
//
//#include <stdio.h>
//
//#endif /* SDKMessage_hpp */

#include <string.h>
#include <stdio.h>
#import <Foundation/Foundation.h>


enum SDKMessageType
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
    
};


class SDKMessage
{
public:
    SDKMessage(int type)
    {
        Type = type;
    }
    
    
    /// <summary>
    /// 调用方法类型.
    /// </summary>
    int Type = -1;
    
    
    
    
    
    
    
    
    
    
    /////////////////////////Unity 传递给 SDK 的数据.
    
    
    /// <summary>
    /// 价格.
    /// </summary>
    float Money = -1;
    /// <summary>
    /// 订单号
    /// </summary>
    const char * OrderId = "";
    /// <summary>
    /// 创建订单时间.
    /// </summary>
    int RechargeTime = -1;
    /// <summary>
    /// 商品ID.
    /// </summary>
    int ProductID = -1;
    /// <summary>
    /// 商品名字.
    /// </summary>
    const char * ProductName = "";
    /// <summary>
    /// 商品描述.
    /// </summary>
    const char * ProductDescription = "";
    
    
    /// <summary>
    /// 上传信息类型 设备激活 注册 登入 创建角色 进入游戏 升级 升级VIP 注销 退出
    /// </summary>
    int UploadInfoType = -1;
    
    /// <summary>
    /// 角色ID.
    /// </summary>
    long RoleId = -1;
    /// <summary>
    /// 角色名字.
    /// </summary>
    const char * RoleName = "";
    /// <summary>
    /// 角色等级.
    /// </summary>
    int RoleLevel = -1;
    /// <summary>
    /// 角色职业ID.
    /// </summary>
    int RoleProfessionalID = -1;
    /// <summary>
    /// 角色职业名字.
    /// </summary>
    const char * RoleProfessionalName = "";
    /// <summary>
    /// 角色战斗力.
    /// </summary>
    int RolePower = -1;
    /// <summary>
    /// 角色创建时间.
    /// </summary>
    const char * CreateRoleTime = "";
    /// <summary>
    /// 角色升级时间.
    /// </summary>
    const char * RoleUpgradeTime = "";
    /// <summary>
    /// 剩余钻石.
    /// </summary>
    int Diamond = -1;
    /// <summary>
    /// 区服ID.
    /// </summary>
    int AreaId = -1;
    /// <summary>
    /// 区服名字.
    /// </summary>
    const char * ArenName = "";
    /// <summary>
    /// VIP等级.
    /// </summary>
    int VIPLevel = -1;
    /// <summary>
    /// 公会Id.
    /// </summary>
    long GangID = -1;
    /// <summary>
    /// 公会名字.
    /// </summary>
    const char * GangName = "";
    /// <summary>
    /// 公司名字.
    /// </summary>
    const char * CompanyName = "";
    
    
    
    
    
    
    
    
    
    /////////////////////////SDK 传递给 Unity 的数据.
    
    
    
    
    
    
    
    
    /// <summary>
    /// 用户ID.
    /// </summary>
    const char * UserID = "";
    /// <summary>
    /// Token.
    /// </summary>
    const char * Token = "";
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    /////////////////////////补充的10个变量.
    
    const char * Variable0 = "";
    const char * Variable1 = "";
    const char * Variable2 = "";
    const char * Variable3 = "";
    const char * Variable4 = "";
    const char * Variable5 = "";
    const char * Variable6 = "";
    const char * Variable7 = "";
    const char * Variable8 = "";
    const char * Variable9 = "";
    
    
    
    /// <summary>
    /// 打印SDKMessage信息.
    /// </summary>
    /// <param name="message">Message.</param>
    static void ShowSDKMessageInfo(SDKMessage* message)
    {
        Log("SDKMessage : ShowSDKMessageInfo Type:", message->Type);
        Log("SDKMessage : ShowSDKMessageInfo Money:" , message->Money);
        Log("SDKMessage : ShowSDKMessageInfo OrderId:", message->OrderId);
        Log("SDKMessage : ShowSDKMessageInfo RechargeTime:" , message->RechargeTime);
        Log("SDKMessage : ShowSDKMessageInfo ProductID:" , message->ProductID);
        Log("SDKMessage : ShowSDKMessageInfo ProductName:" , message->ProductName);
        Log("SDKMessage : ShowSDKMessageInfo ProductDescription:" , message->ProductDescription);
        Log("SDKMessage : ShowSDKMessageInfo UploadInfoType:" , message->UploadInfoType);
        Log("SDKMessage : ShowSDKMessageInfo RoleId:" , message->RoleId);
        Log("SDKMessage : ShowSDKMessageInfo RoleName:" , message->RoleName);
        Log("SDKMessage : ShowSDKMessageInfo RoleLevel:" , message->RoleLevel);
        Log("SDKMessage : ShowSDKMessageInfo RoleProfessionalID:" , message->RoleProfessionalID);
        Log("SDKMessage : ShowSDKMessageInfo RoleProfessionalName:" , message->RoleProfessionalName);
        Log("SDKMessage : ShowSDKMessageInfo RolePower:" , message->RolePower);
        Log("SDKMessage : ShowSDKMessageInfo CreateRoleTime:" , message->CreateRoleTime);
        Log("SDKMessage : ShowSDKMessageInfo RoleUpgradeTime:" , message->RoleUpgradeTime);
        Log("SDKMessage : ShowSDKMessageInfo Diamond:" , message->Diamond);
        Log("SDKMessage : ShowSDKMessageInfo AreaId:" , message->AreaId);
        Log("SDKMessage : ShowSDKMessageInfo ArenName:" , message->ArenName);
        Log("SDKMessage : ShowSDKMessageInfo VIPLevel:" , message->VIPLevel);
        Log("SDKMessage : ShowSDKMessageInfo GangID:" , message->GangID);
        Log("SDKMessage : ShowSDKMessageInfo GangName:" , message->GangName);
        Log("SDKMessage : ShowSDKMessageInfo CompanyName:" , message->CompanyName);
        Log("SDKMessage : ShowSDKMessageInfo UserID:" , message->UserID);
        Log("SDKMessage : ShowSDKMessageInfo Variable0:" , message->Variable0);
        Log("SDKMessage : ShowSDKMessageInfo Variable1:" , message->Variable1);
        Log("SDKMessage : ShowSDKMessageInfo Variable2:" , message->Variable2);
        Log("SDKMessage : ShowSDKMessageInfo Variable3:" , message->Variable3);
        Log("SDKMessage : ShowSDKMessageInfo Variable4:" , message->Variable4);
        Log("SDKMessage : ShowSDKMessageInfo Variable5:" , message->Variable5);
        Log("SDKMessage : ShowSDKMessageInfo Variable6:" , message->Variable6);
        Log("SDKMessage : ShowSDKMessageInfo Variable7:" , message->Variable7);
        Log("SDKMessage : ShowSDKMessageInfo Variable8:" , message->Variable8);
        Log("SDKMessage : ShowSDKMessageInfo Variable9:" , message->Variable9);
    }
    
    static void Log(const char* log,const char* info)
    {
        NSLog(@"%s%s",log,info);
    }
    static void Log(const char* log,int info)
    {
        NSLog(@"%s%d",log,info);
    }
    static void Log(const char* log,float info)
    {
        NSLog(@"%s%f",log,info);
    }
    static void Log(const char* log,long info)
    {
        NSLog(@"%s%ld",log,info);
    }
};



