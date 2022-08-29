using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace PS.Flashlight.Inputs
{
    /// <summary>
    /// Module to receive input from UI.
    /// </summary>
    [AddComponentMenu("Pavlushka Store/Input/Mobile/ButtonHandler")]
    [RequireComponent(typeof(Graphic))]
    public class ButtonHandler : MonoBehaviour, IPointerClickHandler, IPointerUpHandler, IPointerDownHandler
    {
        /// <summary>
        /// Called when a button is pressed.
        /// </summary>
        public event Action OnDownEvent;

        /// <summary>
        /// Checks if the button is hold.
        /// </summary>
        /// <return> Is Button Hold?</return>
        public bool IsButtonHold { get; private set; }

        public void OnPointerClick(PointerEventData eventData) { if(OnDownEvent != null) OnDownEvent(); }
        public void OnPointerDown(PointerEventData eventData) { IsButtonHold = true; }
        public void OnPointerUp(PointerEventData eventData) { IsButtonHold = false; }
    }
}
