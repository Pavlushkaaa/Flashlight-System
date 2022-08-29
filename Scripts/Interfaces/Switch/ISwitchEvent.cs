using System;
using UnityEngine;

namespace PS.Flashlight
{
    /// <summary>
    /// Flashlight switch event interface.
    /// </summary>
    public interface ISwitchEvent
    {
        /// <summary>
        /// Flashlight state changed event.
        /// </summary>
        event Action OnStateChangedEvent;

        /// <summary>
        /// Flashlight enabled event.
        /// </summary>
        event Action OnEnabledEvent;

        /// <summary>
        /// Flashlight disabled event.
        /// </summary>
        event Action OnDisabledEvent;
    }
}
