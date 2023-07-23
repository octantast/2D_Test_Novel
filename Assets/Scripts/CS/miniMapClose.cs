
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Naninovel;
using Naninovel.Commands;

namespace Naninovel.UI
{
    [CommandAlias("miniMapClose")]
    public class miniMapClose : Command
    {
        private QuestLog miniMap;

        public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
        {
            if (miniMap == null)
            {
                miniMap = Engine.GetService<IUIManager>().GetUI<QuestLog>();
            }
            miniMap?.Hide();
            return UniTask.CompletedTask;
        }

    }
}