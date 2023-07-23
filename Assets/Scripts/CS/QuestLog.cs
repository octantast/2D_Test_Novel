
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Naninovel.UI
{
    [RequireComponent(typeof(CanvasGroup))]
    // CustomUI implements the IManagedUI interface
    public class QuestLog : CustomUI
    {
        // Implement the required methods from the IManagedUI interface
        public string PanelId => "QuestLog"; // Unique identifier for your custom UI panel

    }
}
