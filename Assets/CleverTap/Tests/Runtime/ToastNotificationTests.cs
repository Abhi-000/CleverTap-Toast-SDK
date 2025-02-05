using NUnit.Framework;
using System.Collections;
using CleverTap.Notifications;

namespace CleverTap.Tests
{
    public class ToastNotificationTests
    {
        [Test]
        public void ToastNotificationManager_Singleton_IsCreated()
        {
            var instance = ToastNotificationManager.Instance;
            Assert.IsNotNull(instance, "Toast Notification Manager instance should not be null");
        }

        [Test]
        public void ShowToast_ShortDuration_DoesNotThrowException()
        {
            Assert.DoesNotThrow(() =>
            {
                ToastNotificationManager.Instance.ShowToast("Test Short Toast");
            }, "Short toast should not throw an exception");
        }

        [Test]
        public void ShowToast_LongDuration_DoesNotThrowException()
        {
            Assert.DoesNotThrow(() =>
            {
                ToastNotificationManager.Instance.ShowToast("Test Long Toast", ToastNotificationManager.ToastDuration.Long);
            }, "Long toast should not throw an exception");
        }
    }
}