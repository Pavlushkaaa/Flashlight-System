using System;

namespace PS.Flashlight.Inputs
{
    /// <summary>
    /// Flashlight key input events.
    /// </summary>
    public interface IKeyInputEvent
    {   
        /// <summary>
        /// Called when the key is pressed.
        /// </summary>
        event Action OnDownEvent;

        /// <summary>
        /// Called when the key is up.
        /// </summary>
        event Action OnUpEvent;

        /// <summary>
        /// Called when a key is hold.
        /// </summary>
        event Action OnHoldEvent;
    }
}
