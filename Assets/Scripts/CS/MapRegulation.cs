using System.Collections;
using System.Collections.Generic;
using Naninovel;
using Naninovel.Commands;
using UnityEngine;
using UnityEngine.UI;
using Naninovel.Runtime.UI;

namespace Naninovel.UI
{
    [CommandAlias("MapRegulation")]
    public class MapRegulation : Command
    {
        // отображает текст и меняет флажок на карте
        private GameObject questTextHolder;
        private GameObject questArrow;
        private Text questText;
        public StringParameter missionText;
        public IntegerParameter markedRoom;
        private Arrow arrowScript;

        public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
        {
            if (Assigned(missionText))
            {
                if (questText == null)
                {
                    questTextHolder = GameObject.Find("TextOfQuest");
                    questText = questTextHolder.GetComponent<Text>();
                }
                if(questArrow == null)
                {
                    questArrow = GameObject.Find("QuestArrow");
                    arrowScript = questArrow.GetComponent<Arrow>();
                }
                questText.text = missionText;
                if (markedRoom >= 0)
                {
                    questArrow.transform.SetParent(arrowScript.dots[markedRoom].transform);
                    questArrow.transform.localPosition = new Vector3(0, -50, 0);
                }
                else
                {
                    questArrow.SetActive(false);
                }
            }
            return UniTask.CompletedTask;
        }

    }

}