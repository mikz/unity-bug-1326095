using UnityEngine;
using UnityEngine.InputSystem.DualShock;
using UnityEngine.InputSystem.Layouts;

namespace InputSystem
{
    internal static class GamepadSupport
    {
        [RuntimeInitializeOnLoadMethod]
        public static void Initialize()
        {

// Taken from Library/PackageCache/com.unity.inputsystem@1.0.1/InputSystem/Plugins/DualShock/DualShockGamepadHID.cs
#if UNITY_EDITOR || UNITY_STANDALONE_OSX || UNITY_STANDALONE_WIN || UNITY_WSA
            // ps4 controller connected by bluetooth on mac
            UnityEngine.InputSystem.InputSystem.RegisterLayoutMatcher<DualShock4GamepadHID>(
                new InputDeviceMatcher()
                    .WithInterface("HID")
                    .WithCapability("vendorId", 0x54C) // Sony Entertainment.
                    .WithCapability("productId", 0x54C4)); // Wireless controller.

            // Also set up PS5 controller.
            UnityEngine.InputSystem.InputSystem.RegisterLayoutMatcher<DualShock4GamepadHID>(
                new InputDeviceMatcher()
                    .WithInterface("HID")
                    .WithCapability("vendorId", 0x54C) // Sony Entertainment.
                    .WithCapability("productId", 0xCE6)); // Wireless controller.

            UnityEngine.InputSystem.InputSystem.RegisterLayoutMatcher<DualShock4GamepadHID>(
                new InputDeviceMatcher()
                    .WithInterface("HID")
                    .WithProduct("DUALSHOCK 4 Wireless Controller"));
#endif
        }
    }
}