using Assets.Scripts.GameplayComponents.Managers;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.FillInfoScripts
{
    public class FillNewspaper : MonoBehaviour
    {
        public List<TMP_Text> companyObject;
        void Awake()
        {
            for (int i = 0; i < GameplayManager.gameplayModel.Newspaper.Subjects.Count; i++)
            {
                companyObject[i].text = GameplayManager.gameplayModel.Newspaper.Subjects[i].Headline.Text.Replace("***", GameplayManager.gameplayModel.Newspaper.Subjects[i].Company.Name);
            }
        }
    }
}
