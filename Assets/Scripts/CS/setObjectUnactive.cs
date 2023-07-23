using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Naninovel;
using Naninovel.Commands;

namespace Naninovel.UI
{
    [CommandAlias("setObjectUnactive")]
    public class setObjectUnactive : Command
    {
        private ObjectHolder objectHolder;

        public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
        {
            if (objectHolder == null)
            {
                objectHolder = Engine.GetService<IUIManager>().GetUI<ObjectHolder>();
            }
            objectHolder?.Hide();
            return UniTask.CompletedTask;
        }

    }
}