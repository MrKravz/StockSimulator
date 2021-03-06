using Assets.Scripts;
using System.Collections.Generic;
using UnityEngine;

public class FillExchangeInformation : MonoBehaviour
{
    [SerializeField] CompanyPreview companyObject;
    [SerializeField] RectTransform content;
    [SerializeField] MoneyInformationView currencyViewManager;
    private void Awake()
    {
        OnReceiveUpdate(GameplayManager.gameplayModel.Companies);
    }
    private void OnReceiveUpdate(Dictionary<int, Company> companies)
    {
        foreach (Transform item in content)
        {
            Destroy(item.gameObject);
        }
        foreach (var item in companies)
        {
            var instance = Instantiate(companyObject, content);
            instance.View(item.Key, item.Value, currencyViewManager);
            currencyViewManager.companiesPreview.Add(instance);
        }
    }
}

