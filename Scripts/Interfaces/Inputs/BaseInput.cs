using System;
using UnityEngine;
using PS.Flashlight.Models;

namespace PS.Flashlight.Inputs
{
    /// <summary>
    /// Base module for all input types.
    /// </summary>
    public abstract class BaseInput : MonoBehaviour, IKeyInputEvent
    {
        #region Input Events
        public virtual event Action OnDownEvent;
        public virtual event Action OnUpEvent;
        public virtual event Action OnHoldEvent;
        #endregion

        [SerializeField] private InputMethod _inputMethod = InputMethod.Press;

        private Action[] _inputMethods;

        private void Start()
        {
            _inputMethods = new Action[] { () => CheckPressInput(), () => CheckHoldInput() };
        }

        private void Update() { CheckInput(); }

        #region Input method: Press
        protected abstract bool IsKeyDown();

        protected virtual void CheckPressInput()
        {
            if(IsKeyDown() && OnDownEvent != null)
                OnDownEvent();
        }
        #endregion

        #region Input method: Hold
        protected abstract bool IsKeyHold();

        protected virtual void CheckHoldInput()
        {
            if(IsKeyHold() && OnHoldEvent != null)
                OnHoldEvent();

            else if(OnUpEvent != null)
                OnUpEvent();
        }
        #endregion

        private void CheckInput() { _inputMethods[(int)_inputMethod](); }
    }
}
