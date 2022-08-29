using System;
using UnityEngine;
using PS.Flashlight.Models;

namespace PS.Flashlight
{
    /// <summary>
    /// Flashlight switch module.
    /// </summary>
    [AddComponentMenu("Pavlushka Store/Switch")]
    public class Switch : MonoBehaviour, ISwitch, ISwitchEvent, ISwitchInfo
    {
        #region Switch Events
        public event Action OnStateChangedEvent;
        public event Action OnEnabledEvent;
        public event Action OnDisabledEvent;
        #endregion

        [SerializeField] private FlashlightState _stateOnStart = FlashlightState.Disabled;

        public FlashlightState State { get { return _state; } }

        // Light component to be switched.
        [SerializeField] private Light[] _lights;

        private FlashlightState _state = FlashlightState.Disabled;

        private void Start()
        {
            InitializeState();
        }

        // This is required so that all events at the start of the game are called and other modules are initialized.
        private void InitializeState()
        {
            if(_stateOnStart == FlashlightState.Disabled)
                ForceTurnOff();
            else
                ForceTurnOn();
        }

        #region Switch Method
        public void TurnOn()
        {
            if(_state == FlashlightState.Enabled) return;

            ForceTurnOn();
        }

        public void TurnOff()
        {
            if(_state == FlashlightState.Disabled) return;

            ForceTurnOff();
        }

        private void ForceTurnOn()
        {
			for(var i = 0; i < _lights.Length; i++)
			{
				_lights[i].enabled = true;
			}
            _state = FlashlightState.Enabled;

            if(OnEnabledEvent != null) OnEnabledEvent();
            if(OnStateChangedEvent != null) OnStateChangedEvent();
        }

        private void ForceTurnOff()
        {
            for(var i = 0; i < _lights.Length; i++)
			{
				_lights[i].enabled = false;
			}
            _state = FlashlightState.Disabled;

            if(OnDisabledEvent != null) OnDisabledEvent();
            if(OnStateChangedEvent != null) OnStateChangedEvent();
        }
        #endregion
    }
}
