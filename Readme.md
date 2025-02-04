# CleverTap Unity Toast SDK (Test Project)  

🚀 A Unity package to display **Toast Notifications** on **Android** and **iOS** using a custom GameObject. This project is a **test assignment** and is **not an official CleverTap SDK**.  

## 📌 **Disclaimer**  
This repository is created as part of a **Unity SDK developer assignment**. It is **not an official CleverTap SDK** and is meant for **demonstration purposes only**.  

## 📦 **Installation**  

### 1️⃣ **Import the Unity Package**  
1. Download the `CleverTapToastNotification.unitypackage` file from the **Releases** section.  
2. Open your Unity project.  
3. Go to **Assets > Import Package > Custom Package** and select `CleverTapToastNotification.unitypackage`.  
4. Ensure that all files are selected and click **Import**.  

### 2️⃣ **Ensure Android/iOS Support**  
- **Android:** Enable **Android Build Support** in Unity **(File > Build Settings > Android)**.  
- **iOS:** Ensure **Xcode & iOS SDK** are set up correctly.  

### 3️⃣ Install Dependencies
🔹 Ensure **TextMeshPro** is installed:

1. Go to `Window > Package Manager > Unity Registry > TextMeshPro`.
2. Click **Install** (if not already installed).

🔹 If the sample scene does not display text properly, go to **Window > TextMeshPro > Import TMP Essential Resources**.

## 🚀 **Usage**  
### 1️⃣ **Show a Toast Notification**  
Add the `ToastNotificationManager` prefab to your scene and call:  

```csharp
using CleverTap.Notifications;

// Show a short toast
ToastNotificationManager.Instance.ShowToast("Hello, CleverTap!");

// Show a long toast
ToastNotificationManager.Instance.ShowToast("Long message", ToastNotificationManager.ToastDuration.Long);
```

### 2️⃣ Trigger a Toast on Button Click
```csharp
using UnityEngine;
using UnityEngine.UI;
using CleverTap.Notifications;

public class ToastNotificationButton : MonoBehaviour
{
    public Button toastButton;

    void Start()
    {
        toastButton.onClick.AddListener(ShowToast);
    }

    void ShowToast()
    {
        ToastNotificationManager.Instance.ShowToast("Button Clicked!");
    }
}
```


### 🎮 Demo Scene
📂 Location: `Assets/Samples~/ToastDemoScene.unity`

### 🛠 Project Architecture
🔹 SDK Folder Structure
```plaintext
📂 CleverTap-Unity-Toast-SDK/       # Root folder of the project
│── 📂 Assets/                      # Unity's main asset directory
│    ├── 📂 Editor/                 # Contains editor scripts that should run only inside Unity Editor
│    ├── 📂 Runtime/                # Contains all runtime scripts required for the SDK to function
│    ├── 📂 Samples~/               # Contains sample scenes and example usage of the SDK
│    ├── 📂 Tests/                  # Unit tests for validating SDK functionality
│    ├── 📂 Prefabs/                # Prefabs related to the SDK (e.g., ToastNotificationManager.prefab)
│    ├── 📜 package.json            # Unity package metadata for package manager compatibility
│    ├── 📜 Readme.md               # Documentation explaining usage, installation, and setup
│── 📜 CleverTapToastNotification.unitypackage   # Exported Unity package file for distribution
│── 📜 .gitignore                    # Git ignore file to exclude unnecessary files from version control

```
🔹Singleton Pattern: `ToastNotificationManager` follows a singleton approach to ensure a single instance for notifications.

🔹Platform-Specific Code: Uses `#if UNITY_ANDROID` and `#if UNITY_IOS` for platform-specific API calls.

## 🧪 **Unit Testing**
The package includes unit tests for core functionalities:

✅ Singleton Creation: Ensures `ToastNotificationManager.Instance` is properly initialized.

✅ Toast Display: Verifies toast is shown correctly with different durations.

✅ Error Handling: Ensures exceptions are handled when calling the API.

📂 Test Location: `Assets/Tests/ToastNotificationTests.cs`

To run tests:

1. Open Unity Test Runner (`Window > General > Test Runner`).
2. Select Play Mode Tests or Edit Mode Tests.
3. Click Run All.


## 📋 **Requirements**

✅ Unity 2022.3 LTS or later

✅ Android SDK (for Android builds)

✅ Xcode (for iOS builds)


## 🤔 **FAQ & Troubleshooting**

### 🔹 Why is my toast not showing on Android?

1. Ensure that your AndroidManifest.xml has the necessary permissions.
   
2. Check that Android Build Support is enabled.
   
### 🔹 Does this work on iOS?

  Yes, but you may need native bridging for better customization.

## 📝 **License**

This project is created for testing and educational purposes. Not affiliated with CleverTap.

## 💬 **Questions?**

For any queries, feel free to reach out! 🚀

