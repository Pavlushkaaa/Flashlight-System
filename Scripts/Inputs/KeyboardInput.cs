using UnityEngine;

namespace PS.Flashlight.Inputs
{
    /// <summary>
    /// Keyboard input module.
    /// </summary>
    [AddComponentMenu("Pavlushka Store/Input/Keyboard Input")]
    public class KeyboardInput : BaseInput
    {
        [SerializeField] private KeyCode _switchKey = KeyCode.E;

        protected override bool IsKeyDown() { return Input.GetKeyDown(_switchKey); }

        protected override bool IsKeyHold() { return Input.GetKey(_switchKey); }
    }
}
