using System;
using UnityEngine;
using PS.Flashlight.Models;

namespace PS.Flashlight
{
    /// <summary>
    /// Flashlight switch info interface.
    /// </summary>
    public interface ISwitchInfo
    {
        /// <summary>
        /// Flashlight state: Enabled or Disabled.
        /// </summary>
        FlashlightState State { get; }
    }
}
