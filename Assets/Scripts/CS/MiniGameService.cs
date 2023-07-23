using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Naninovel.UI
{
    [RequireComponent(typeof(CanvasGroup))]
    // CustomUI implements the IManagedUI interface
    public class MiniGameService : CustomUI
    {
        // Implement the required methods from the IManagedUI interface
        public string PanelId => "MiniGameService"; // Unique identifier for your custom UI panel

    }
}