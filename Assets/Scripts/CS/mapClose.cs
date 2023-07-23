
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Naninovel;
using Naninovel.Commands;

namespace Naninovel.UI
{
    [CommandAlias("mapClose")]
    public class mapClose : Command
    {
        private MapUI mapScreen;

        public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
        {
            if (mapScreen == null)
            {
                mapScreen = Engine.GetService<IUIManager>().GetUI<MapUI>();
            }
            mapScreen?.Hide();
            return UniTask.CompletedTask;
        }
    }
}