using UnityEngine;

namespace PS.Flashlight.Inputs
{
    /// <summary>
    /// Axis input module.
    /// </summary>
    [AddComponentMenu("Pavlushka Store/Input/Axis Input", 1)]
    public class AxisInput : BaseInput
    {
        [SerializeField] private string _axisName;

        protected override bool IsKeyDown() { return Input.GetButtonDown(_axisName); }

        protected override bool IsKeyHold() { return Input.GetButton(_axisName); }
    }
}
