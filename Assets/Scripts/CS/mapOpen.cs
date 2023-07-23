
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Naninovel;
using Naninovel.Commands;

namespace Naninovel.UI
{
    [CommandAlias("mapOpen")]
    public class mapOpen : Command
    {
        private MapUI mapScreen;

        public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
        {
            if (mapScreen == null)
            {
                mapScreen = Engine.GetService<IUIManager>().GetUI<MapUI>();
            }
            mapScreen?.Show();
            return UniTask.CompletedTask;
        }

    }
}