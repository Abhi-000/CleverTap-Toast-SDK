using UnityEngine;
using System;

namespace CleverTap.Notifications
{
    public class ToastNotificationManager : MonoBehaviour
    {
        public enum ToastDuration { Short, Long }
        public enum ToastType { Normal, Success, Error }
        public enum ToastPosition
        {
            Bottom = 80, // Gravity.BOTTOM
            Center = 17, // Gravity.CENTER
            Top = 48     // Gravity.TOP
        }


        private static ToastNotificationManager instance;
        public static ToastNotificationManager Instance
        {
            get
            {
                if (instance == null)
                {
                    GameObject go = new GameObject("ToastNotificationManager");
                    instance = go.AddComponent<ToastNotificationManager>();
                    DontDestroyOnLoad(go);
                }
                return instance;
            }
        }

        public void ShowToast(string message, ToastDuration duration = ToastDuration.Short)
        {
#if UNITY_ANDROID && !UNITY_EDITOR
        try
        {
            using (AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
            using (AndroidJavaObject currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity"))
            using (AndroidJavaObject context = currentActivity.Call<AndroidJavaObject>("getApplicationContext"))
            using (AndroidJavaClass toastClass = new AndroidJavaClass("com.clevertap.toastnotification.CleverTapToastNotification"))
            {
                int durationValue = duration == ToastDuration.Short ? 
                    toastClass.CallStatic<int>("getShortDuration") : 
                    toastClass.CallStatic<int>("getLongDuration");

                toastClass.CallStatic("showToast", context, message, durationValue);
            }
        }
        catch (System.Exception e)
        {
            Debug.LogError($"Failed to show toast: {e.Message}");
        }
#endif
            Debug.Log("Displayed a " + duration + " toast message:" +message);
        }
    }
}
