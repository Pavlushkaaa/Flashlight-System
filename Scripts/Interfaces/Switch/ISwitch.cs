using System;
using UnityEngine;

namespace PS.Flashlight
{
    /// <summary>
    /// Flashlight state switching interface.
    /// </summary>
    public interface ISwitch
    {
        /// <summary>
        /// Enable flashlight.
        /// </summary>
        void TurnOn();

        /// <summary>
        /// Disable flashlight.
        /// </summary>
        void TurnOff();
    }
}
