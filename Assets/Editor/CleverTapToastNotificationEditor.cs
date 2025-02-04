using UnityEngine;
using UnityEditor;
using CleverTap.Notifications;

namespace CleverTap.Editor
{
    [CustomEditor(typeof(ToastNotificationManager))]
    public class CleverTapToastNotificationEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            ToastNotificationManager manager = (ToastNotificationManager)target;

            EditorGUILayout.HelpBox("CleverTap Toast Notification Manager", MessageType.Info);

            if (GUILayout.Button("Test Short Toast"))
            {
                manager.ShowToast("Test Short Toast");
            }

            if (GUILayout.Button("Test Long Toast"))
            {
                manager.ShowToast("Test Long Toast", ToastNotificationManager.ToastDuration.Long);
            }

            DrawDefaultInspector();
        }
    }
}
