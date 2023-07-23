using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Naninovel;
using Naninovel.Commands;
using DTT.MinigameBase;
using DTT.MinigameBase.Timer;
using DTT.MinigameBase.UI;

namespace DTT.MinigameMemory
{
    [CommandAlias("startMiniGame")]
    public class startMiniGame : Command
    {
        private GameObject MiniGameManager;
        private MemoryGameManager gameScript;
        public MemoryGameSettings settings;

        public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
        {
            if (gameScript == null)
            {
                MiniGameManager = GameObject.Find("MiniGameManager");
                gameScript = MiniGameManager.GetComponent<MemoryGameManager>();
            }
            gameScript.StartGame(gameScript._settings);
            return UniTask.CompletedTask;
        }
    }
    
}
