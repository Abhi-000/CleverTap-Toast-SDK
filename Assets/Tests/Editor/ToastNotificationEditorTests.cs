using NUnit.Framework;
using UnityEngine;
using UnityEditor;
using CleverTap.Notifications;

namespace CleverTap.Tests.Editor
{
    public class ToastNotificationEditorTests
    {
        [Test]
        public void ToastNotificationManagerEditor_CreatesInspector()
        {
            // Create a temporary GameObject with ToastNotificationManager
            GameObject go = new GameObject();
            ToastNotificationManager manager = go.AddComponent<ToastNotificationManager>();

            // Create an editor for the manager
            var editor = UnityEditor.Editor.CreateEditor(manager);

            Assert.IsNotNull(editor, "Editor should be created successfully");

            // Clean up
            Object.DestroyImmediate(go);
            Object.DestroyImmediate(editor);
        }
    }
}