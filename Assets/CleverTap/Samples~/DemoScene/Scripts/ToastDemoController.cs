using UnityEngine;
using CleverTap.Notifications;

public class ToastDemoController : MonoBehaviour
{
    public void ShowShortToast()
    {
        ToastNotificationManager.Instance.ShowToast("Short Toast Message");
    }

    public void ShowLongToast()
    {
        ToastNotificationManager.Instance.ShowToast("Long Toast Message", ToastNotificationManager.ToastDuration.Long);
    }

    public void ShowErrorToast()
    {
        ToastNotificationManager.Instance.ShowToast("Error Occurred!", ToastNotificationManager.ToastDuration.Long);
    }
}
