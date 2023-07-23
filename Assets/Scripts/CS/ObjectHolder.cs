using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Naninovel.UI
{
    [RequireComponent(typeof(CanvasGroup))]
    // CustomUI implements the IManagedUI interface
    public class ObjectHolder : CustomUI
    {
        // Implement the required methods from the IManagedUI interface
        public string PanelId => "ObjectHolder"; // Unique identifier for your custom UI panel

    }
}
