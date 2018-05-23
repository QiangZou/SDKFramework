using UnityEngine;
using System.Runtime.InteropServices;

namespace SDKFramework
{
    public class SDKManager : MonoBehaviour
    {
        public static SDKManager GetSingleton()
        {
            if (instance == null)
            {
                GameObject go = new GameObject("SDKManager");
                instance = go.AddComponent<SDKManager>();
            }
            return instance;
        }


        [DllImport("__Internal")]
        public static extern string UnityToPhoneSDK(string data);

        static SDKManager instance;

        IUnityToSDK iUnityToSDK;

        ISDKToUnity iSDKToUnity;

        public IUnityToSDK IUnityToSDK { get { return iUnityToSDK; } }

        public ISDKToUnity ISDKToUnity { get { return iSDKToUnity; } }

        void Awake()
        {
            instance = this;

            DontDestroyOnLoad(gameObject);

            GetChannelName();
        }


        /// <summary>
        /// 获取渠道名字.
        /// </summary>
        void GetChannelName()
        {
            SDKConfig.Log("SDKManager : GetChannelName()");

            SDKMessage message = new SDKMessage((int)SDKMessageType.GetChannelName);

            string channelName = UnityToSDK(message);


            //**工厂模式  根据渠道名字来实例化不同的类

            iUnityToSDK = SDKConfig.GetUnityToSDK(channelName);

            iSDKToUnity = SDKConfig.GetSDKToUinty(channelName);
        }

        /// <summary>
        /// Unity层调用SDK层.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public string UnityToSDK(SDKMessage message)
        {
            SDKConfig.ShowSDKMessageInfo(message);

            string data = JsonUtility.ToJson(message);

            return UnityToSDK(data);
        }

        /// <summary>
        /// Unity层调用SDK层.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public string UnityToSDK(string message)
        {
            SDKConfig.Log("SDKManager : UnityToSDK() message :" + message);

            //调用Android
            if (Application.platform == RuntimePlatform.Android)
            {
                using (AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
                {

                    AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");
                    return jo.Call<string>("UnityToSDK", message);
                }
            }
            //调用IOS
            else if (Application.platform == RuntimePlatform.IPhonePlayer)
            {
                return UnityToPhoneSDK(message);
            }

            SDKConfig.Log("SDKManager : UnityToSDK Application.platform Error");

            return "SDKManager : UnityToSDK Error";
        }



        /// <summary>
        /// SDK层调用Uniyt层.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string SDKToUnity(string data)
        {
            SDKConfig.Log("SDKManager : SDKToUnity() data:" + data);

            SDKMessage message = JsonUtility.FromJson<SDKMessage>(data);

            SDKConfig.ShowSDKMessageInfo(message);

            SDKMessageType type = (SDKMessageType)message.Type;

            switch (type)
            {
                case SDKMessageType.LoginSucceed:
                    iSDKToUnity.LoginSucceed(message);
                    break;
                case SDKMessageType.LogoutSucceed:
                    iSDKToUnity.LogoutSucceed();
                    break;
                default:
                    return iSDKToUnity.Other(message);
            }

            return "null";
        }
    }
}
