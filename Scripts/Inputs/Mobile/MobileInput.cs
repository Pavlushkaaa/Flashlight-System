using System;
using UnityEngine;

namespace PS.Flashlight.Inputs
{
    /// <summary>
    /// Mobile input module.
    /// </summary>
    [AddComponentMenu("Pavlushka Store/Input/Mobile/Mobile Input")]
    public class MobileInput : BaseInput, IKeyInputEvent
    {
        public override event Action OnDownEvent;

        [SerializeField] private ButtonHandler _buttonHandler;

        private void OnEnable()
        {
            _buttonHandler.OnDownEvent += CheckKeySwitchEvent;
        }

        private void OnDisable()
        {
            _buttonHandler.OnDownEvent -= CheckKeySwitchEvent;
        }

        protected override bool IsKeyHold()
        {
            return _buttonHandler.IsButtonHold;
        }

        private void CheckKeySwitchEvent()
        {
            if(OnDownEvent != null) OnDownEvent();
        }

        #region !!!Plug!!!, sorry, but that's the easiest way to do it
        protected override void CheckPressInput()
        {
            // Nothing, because we have a subscription to the button click event and there is no need for verification
        }

        protected override bool IsKeyDown()
        {
            return false; // Nothing, because we have a subscription to the button click event and there is no need for verification
        }
        #endregion
    }
}
