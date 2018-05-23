package com.SDKFramework.SDKFramework;

import com.google.gson.Gson;
import com.unity3d.player.*;
import android.app.Activity;
import android.content.res.Configuration;
import android.graphics.PixelFormat;
import android.os.Bundle;
import android.util.Log;
import android.view.KeyEvent;
import android.view.MotionEvent;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;

public class UnityPlayerActivity extends Activity {
	protected UnityPlayer mUnityPlayer; // don't change the name of this
										// variable; referenced from native code

	public String UnityToSDK(String data) {

		Log.i("UnityToSDK", data);

		Gson gson = new Gson();

		SDKMessage message = gson.fromJson(data, SDKMessage.class);

		SDKMessage.ShowSDKMessageInfo(message);

		SDKMessageType type = SDKMessageType.values()[message.Type];

		if (message.Type == SDKMessageType.GetChannelName.ordinal()) {
			return GetChannelName();
		} else if (message.Type == SDKMessageType.Init.ordinal()) {
			Init();
		} else if (message.Type == SDKMessageType.Login.ordinal()) {
			Login();
		} else if (message.Type == SDKMessageType.Logout.ordinal()) {
			Logout();
		} else if (message.Type == SDKMessageType.UploadInfo.ordinal()) {
			UploadInfo(message);
		} else if (message.Type == SDKMessageType.Pay.ordinal()) {
			Pay(message);
		}

		return "null";
	}

	String GetChannelName() {
		return "XiaoMi";
	}

	void Init() {
		// 调用SDK的初始化
		Log.i("UnityToSDK", "初始化成功");
	}

	void Login() {
		// 调用SDK的登入
		Log.i("UnityToSDK", "登入成功");

		SDKMessage message = new SDKMessage(
				SDKMessageType.LoginSucceed.ordinal());

		message.UserID = "aaaa1";

		Gson gson = new Gson();

		String data = gson.toJson(message);

		Log.i("UnityToSDK", "data :" + data);

		UnityPlayer.UnitySendMessage("SDKManager", "SDKToUnity", data);
	}

	void Logout() {
		// 调用SDK的切换账号
		Log.i("UnityToSDK", "注销成功");
	}

	void UploadInfo(SDKMessage message) {
		// 调用SDK的上传
		Log.i("UnityToSDK", "上传成功");
	}

	void Pay(SDKMessage message) {
		// 调用SDK的支付
		Log.i("UnityToSDK", "支付成功");
	}

	// Setup activity layout
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		requestWindowFeature(Window.FEATURE_NO_TITLE);
		super.onCreate(savedInstanceState);

		getWindow().setFormat(PixelFormat.RGBX_8888); // <--- This makes xperia
														// play happy

		mUnityPlayer = new UnityPlayer(this);
		setContentView(mUnityPlayer);
		mUnityPlayer.requestFocus();
	}

	// Quit Unity
	@Override
	protected void onDestroy() {
		mUnityPlayer.quit();
		super.onDestroy();
	}

	// Pause Unity
	@Override
	protected void onPause() {
		super.onPause();
		mUnityPlayer.pause();
	}

	// Resume Unity
	@Override
	protected void onResume() {
		super.onResume();
		mUnityPlayer.resume();
	}

	// This ensures the layout will be correct.
	@Override
	public void onConfigurationChanged(Configuration newConfig) {
		super.onConfigurationChanged(newConfig);
		mUnityPlayer.configurationChanged(newConfig);
	}

	// Notify Unity of the focus change.
	@Override
	public void onWindowFocusChanged(boolean hasFocus) {
		super.onWindowFocusChanged(hasFocus);
		mUnityPlayer.windowFocusChanged(hasFocus);
	}

	// For some reason the multiple keyevent type is not supported by the ndk.
	// Force event injection by overriding dispatchKeyEvent().
	@Override
	public boolean dispatchKeyEvent(KeyEvent event) {
		if (event.getAction() == KeyEvent.ACTION_MULTIPLE)
			return mUnityPlayer.injectEvent(event);
		return super.dispatchKeyEvent(event);
	}

	// Pass any events not handled by (unfocused) views straight to UnityPlayer
	@Override
	public boolean onKeyUp(int keyCode, KeyEvent event) {
		return mUnityPlayer.injectEvent(event);
	}

	@Override
	public boolean onKeyDown(int keyCode, KeyEvent event) {
		return mUnityPlayer.injectEvent(event);
	}

	@Override
	public boolean onTouchEvent(MotionEvent event) {
		return mUnityPlayer.injectEvent(event);
	}

	/* API12 */public boolean onGenericMotionEvent(MotionEvent event) {
		return mUnityPlayer.injectEvent(event);
	}
}
