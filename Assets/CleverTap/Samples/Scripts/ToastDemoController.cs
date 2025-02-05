using UnityEngine;
using UnityEngine.UI;
using TMPro;
using CleverTap.Notifications;

public class ToastDemoController : MonoBehaviour
{
    [Header("Toast Settings")]
    [SerializeField] private string shortToastMessage = "This is a short toast message";
    [SerializeField] private string longToastMessage = "This is a longer toast message that demonstrates extended duration";

    [Header("UI References")]
    [SerializeField] private Button shortToastButton;
    [SerializeField] private Button longToastButton;

    [Header("Optional UI Customization")]
    [SerializeField] private TMP_InputField messageInput;
    [SerializeField] private Toggle useCustomMessageToggle;

    private void Awake()
    {
        // Setup button listeners
        if (shortToastButton != null)
            shortToastButton.onClick.AddListener(ShowShortToast);

        if (longToastButton != null)
            longToastButton.onClick.AddListener(ShowLongToast);
    }

    private string GetCurrentMessage()
    {
        if (useCustomMessageToggle != null && useCustomMessageToggle.isOn &&
            messageInput != null && !string.IsNullOrEmpty(messageInput.text))
        {
            return messageInput.text;
        }
        return null;
    }

    public void ShowShortToast()
    {
        string message = GetCurrentMessage() ?? shortToastMessage;
        ToastNotificationManager.Instance.ShowToast(message);
    }

    public void ShowLongToast()
    {
        string message = GetCurrentMessage() ?? longToastMessage;
        ToastNotificationManager.Instance.ShowToast(message, ToastNotificationManager.ToastDuration.Long);
    }
    private void OnDestroy()
    {
        // Clean up listeners
        if (shortToastButton != null)
            shortToastButton.onClick.RemoveListener(ShowShortToast);

        if (longToastButton != null)
            longToastButton.onClick.RemoveListener(ShowLongToast);
    }
}