using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class MoneyInformationView : MonoBehaviour
{
    [SerializeField] TMP_Text currentMoney;
    public List<CompanyPreview> companiesPreview = new List<CompanyPreview>();
    private void Awake()
    {
        InformationChange();
    }
    public void InformationChange()
    {
        foreach (var item in companiesPreview)
        {
            item.PlusPrice.GetComponentInChildren<TMP_Text>().text = "+" + GameplayManager.gameplayModel.Companies.Where(x => x.Value.Name == item.Name.text).First().Value.PriceComponent.CurrentPrice.ToString();
            item.MinusPrice.GetComponentInChildren<TMP_Text>().text = "-" + GameplayManager.gameplayModel.Companies.Where(x => x.Value.Name == item.Name.text).First().Value.PriceComponent.CurrentPrice.ToString();
        }
        currentMoney.text = GameplayManager.gameplayModel.Player.MoneyComponent.CurrentMoney + "$";
    }
}
