
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Naninovel;
using Naninovel.Commands;

namespace Naninovel.UI
{
    [CommandAlias("miniMapOpen")]
    public class miniMapOpen : Command
    {
        private QuestLog miniMap;

        public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
        {
            if (miniMap == null)
            {
                miniMap = Engine.GetService<IUIManager>().GetUI<QuestLog>();
            }
            miniMap?.Show();
            return UniTask.CompletedTask;
        }

    }
}