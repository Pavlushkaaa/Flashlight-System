using UnityEngine;
using PS.Flashlight.Models;

namespace PS.Flashlight.Inputs
{
    /// <summary>
    /// Mouse input module.
    /// </summary>
    [AddComponentMenu("Pavlushka Store/Input/Mouse Input")]
    public class MouseInput : BaseInput
    {
        [SerializeField] private MouseButton _mouseButton = MouseButton.Right;

        protected override bool IsKeyDown() { return Input.GetMouseButtonDown((int)_mouseButton); }

        protected override bool IsKeyHold() { return Input.GetMouseButton((int)_mouseButton); }

    }
}
