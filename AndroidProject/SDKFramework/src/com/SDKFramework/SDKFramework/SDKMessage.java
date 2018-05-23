
package com.SDKFramework.SDKFramework;

import android.util.Log;

enum SDKMessageType {
	NUll,

	GetChannelName,

	Init, Login, Logout, UploadInfo, Pay,

	LoginSucceed, LogoutSucceed,

	/**
	 * 补充的5个方法.
	 */
	Method0, Method1, Method2, Method3, Method4;
}

public class SDKMessage {
	public SDKMessage(int type) {
		Type = type;
	}

	/**
	 * 调用方法类型.
	 */
	public int Type = -1;

	// ///////////////////////Unity 传递给 SDK 的数据.

	/**
	 * 价格.
	 */
	public float Money = -1f;
	/**
	 * 订单号
	 */
	public String OrderId = "";
	/**
	 * 创建订单时间.
	 */
	public long RechargeTime = -1;
	/**
	 * 商品ID.
	 */
	public int ProductID = -1;
	/**
	 * 商品名字.
	 */
	public String ProductName = "";
	/**
	 * 商品描述.
	 */
	public String ProductDescription = "";

	/**
	 * 上传信息类型 设备激活 注册 登入 创建角色 进入游戏 升级 升级VIP 注销 退出
	 */
	public int UploadInfoType = -1;

	/**
	 * 角色ID.
	 */
	public long RoleId = -1;
	/**
	 * 角色名字.
	 */
	public String RoleName = "";
	/**
	 * 角色等级.
	 */
	public int RoleLevel = -1;
	/**
	 * 角色职业ID.
	 */
	public int RoleProfessionalID = -1;
	/**
	 * 角色职业名字.
	 */
	public String RoleProfessionalName = "";
	/**
	 * 角色战斗力.
	 */
	public int RolePower = -1;
	/**
	 * 角色创建时间.
	 */
	public String CreateRoleTime = "";
	/**
	 * 角色升级时间.
	 */
	public String RoleUpgradeTime = "";
	/**
	 * 剩余钻石.
	 */
	public int Diamond = -1;
	/**
	 * 区服ID.
	 */
	public int AreaId = -1;
	/**
	 * 区服名字.
	 */
	public String ArenName = "";
	/**
	 * VIP等级.
	 */
	public int VIPLevel = -1;
	/**
	 * 公会Id.
	 */
	public long GangID = -1;
	/**
	 * 公会名字.
	 */
	public String GangName = "";
	/**
	 * 公司名字.
	 */
	public String CompanyName = "";

	// ///////////////////////SDK 传递给 Unity 的数据.

	/**
	 * 用户ID.
	 */
	public String UserID = "";
	/**
	 * Token.
	 */
	public String Token = "";

	// ///////////////////////补充的10个变量.

	public String Variable0 = "";
	public String Variable1 = "";
	public String Variable2 = "";
	public String Variable3 = "";
	public String Variable4 = "";
	public String Variable5 = "";
	public String Variable6 = "";
	public String Variable7 = "";
	public String Variable8 = "";
	public String Variable9 = "";

	public static void ShowSDKMessageInfo(SDKMessage message) {
		Log("SDKMessage : ShowSDKMessageInfo Type:" + message.Type);
		Log("SDKMessage : ShowSDKMessageInfo Money:" + message.Money);
		Log("SDKMessage : ShowSDKMessageInfo OrderId:" + message.OrderId);
		Log("SDKMessage : ShowSDKMessageInfo RechargeTime:"
				+ message.RechargeTime);
		Log("SDKMessage : ShowSDKMessageInfo ProductID:" + message.ProductID);
		Log("SDKMessage : ShowSDKMessageInfo ProductName:"
				+ message.ProductName);
		Log("SDKMessage : ShowSDKMessageInfo ProductDescription:"
				+ message.ProductDescription);
		Log("SDKMessage : ShowSDKMessageInfo UploadInfoType:"
				+ message.UploadInfoType);
		Log("SDKMessage : ShowSDKMessageInfo RoleId:" + message.RoleId);
		Log("SDKMessage : ShowSDKMessageInfo RoleName:" + message.RoleName);
		Log("SDKMessage : ShowSDKMessageInfo RoleLevel:" + message.RoleLevel);
		Log("SDKMessage : ShowSDKMessageInfo RoleProfessionalID:"
				+ message.RoleProfessionalID);
		Log("SDKMessage : ShowSDKMessageInfo RoleProfessionalName:"
				+ message.RoleProfessionalName);
		Log("SDKMessage : ShowSDKMessageInfo RolePower:" + message.RolePower);
		Log("SDKMessage : ShowSDKMessageInfo CreateRoleTime:"
				+ message.CreateRoleTime);
		Log("SDKMessage : ShowSDKMessageInfo RoleUpgradeTime:"
				+ message.RoleUpgradeTime);
		Log("SDKMessage : ShowSDKMessageInfo Diamond:" + message.Diamond);
		Log("SDKMessage : ShowSDKMessageInfo AreaId:" + message.AreaId);
		Log("SDKMessage : ShowSDKMessageInfo ArenName:" + message.ArenName);
		Log("SDKMessage : ShowSDKMessageInfo VIPLevel:" + message.VIPLevel);
		Log("SDKMessage : ShowSDKMessageInfo GangID:" + message.GangID);
		Log("SDKMessage : ShowSDKMessageInfo GangName:" + message.GangName);
		Log("SDKMessage : ShowSDKMessageInfo CompanyName:"
				+ message.CompanyName);
		Log("SDKMessage : ShowSDKMessageInfo UserID:" + message.UserID);
		Log("SDKMessage : ShowSDKMessageInfo Variable0:" + message.Variable0);
		Log("SDKMessage : ShowSDKMessageInfo Variable1:" + message.Variable1);
		Log("SDKMessage : ShowSDKMessageInfo Variable2:" + message.Variable2);
		Log("SDKMessage : ShowSDKMessageInfo Variable3:" + message.Variable3);
		Log("SDKMessage : ShowSDKMessageInfo Variable4:" + message.Variable4);
		Log("SDKMessage : ShowSDKMessageInfo Variable5:" + message.Variable5);
		Log("SDKMessage : ShowSDKMessageInfo Variable6:" + message.Variable6);
		Log("SDKMessage : ShowSDKMessageInfo Variable7:" + message.Variable7);
		Log("SDKMessage : ShowSDKMessageInfo Variable8:" + message.Variable8);
		Log("SDKMessage : ShowSDKMessageInfo Variable9:" + message.Variable9);
	}

	public static void Log(String log) {
		
		Log.i("UnityToSDK", log);
	}
}
