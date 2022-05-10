using Assets.Scripts;
using System.Collections.Generic;
using UnityEngine;

public class FillPortfolio : MonoBehaviour
{
    [SerializeField] InfoPreview companyObject;
    [SerializeField] RectTransform content;
    [SerializeField] TMPro.TMP_Text currentMoney;
    private void Awake()
    {
        OnReceiveUpdate(GameplayManager.gameplayModel.Player.Companies);
        currentMoney.text = GameplayManager.gameplayModel.Player.MoneyComponent.CurrentMoney + "$";
    }
    private void OnReceiveUpdate(Dictionary<int,Company> companies)
    {
        foreach (Transform item in content)
        {
            Destroy(item.gameObject);
        }
        foreach (var item in companies)
        {
            var instance = Instantiate(companyObject, content);
            instance.View(item.Value);
        }
    }
}
