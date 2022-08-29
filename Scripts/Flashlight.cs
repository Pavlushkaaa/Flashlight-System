using UnityEngine;
using PS.Flashlight.Models;
using PS.Flashlight.Inputs;

namespace PS.Flashlight
{
    /// <summary>
    /// The main flashlight module that connects the rest of the modules.
    /// </summary>
    [RequireComponent(typeof(IKeyInputEvent), typeof(ISwitch))]
    [AddComponentMenu("Pavlushka Store/Flashlight")]
    public class Flashlight : MonoBehaviour
    {
        #region Switch
        private ISwitch _switch;
        private ISwitchInfo _switchInfo;
        #endregion

        private IKeyInputEvent _input;

        private void Awake()
        {
            _input = GetComponent<IKeyInputEvent>();
            _switch = GetComponent<ISwitch>();
            _switchInfo = GetComponent<ISwitchInfo>();
        }

        private void OnEnable()
        {
            #region Subscription input events
            _input.OnDownEvent += Switch;
            _input.OnUpEvent += TurnOff;
            _input.OnHoldEvent += TurnOn;
            #endregion
        }

        private void OnDisable()
        {
            #region Unsubscription input events
            _input.OnDownEvent -= Switch;
            _input.OnUpEvent -= TurnOff;
            _input.OnHoldEvent -= TurnOn;
            #endregion
        }

        #region Flashlight Control
        [ContextMenu("Switch Flashlight")]
        private void Switch()
        {
            if(_switchInfo.State != FlashlightState.Enabled)
            {
                TurnOn();
            }
            else
            {
                TurnOff();
            }

        }

        private void TurnOn()
        {
            _switch.TurnOn();
        }

        private void TurnOff()
        {
            _switch.TurnOff();
        }
        #endregion
    }
}
