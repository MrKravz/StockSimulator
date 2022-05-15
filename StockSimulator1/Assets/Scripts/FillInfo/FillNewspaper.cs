using Assets.Scripts.News;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FillNewspaper : MonoBehaviour
{
    public List<TMP_Text> companyObject;
    public Newspaper news { get; private set; } = default;
    void Awake()
    {
        news = GameplayManager.gameplayModel.Newspaper;
        string content;
        for (int i = 0; i < companyObject.Count; i++)
        {
            content = news.Subjects[i].Headline.Text.Replace("***", GameplayManager.gameplayModel.Newspaper.Subjects[i].Company.Name);
            companyObject[i].text = content;
        }
    }
}
