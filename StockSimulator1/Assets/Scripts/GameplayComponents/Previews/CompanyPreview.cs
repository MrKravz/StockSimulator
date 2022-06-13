using Assets.Scripts.GameplayComponents.Managers;
using Assets.Scripts.InfoWorkers;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.GameplayComponents.Previews
{
    public class CompanyPreview : MonoBehaviour
    {
        [field: SerializeField] public TMP_Text Name { get; private set; } = default;
        [field: SerializeField] public TMP_Text Sphere { get; private set; } = default;
        [field: SerializeField] public Button PlusPrice { get; private set; } = default;
        [field: SerializeField] public Button MinusPrice { get; private set; } = default;
        public void View(int companyKey, Company company, MoneyInformationView currencyViewManager)
        {
            Name.text = company.Name;
            Sphere.text = company.Type.ToString();
            PlusPrice.GetComponentInChildren<TMP_Text>().text = "+" + company.PriceComponent.CurrentPrice.ToString();
            StockManager stockManager = new StockManager();
            PlusPrice.onClick.AddListener(() => stockManager.SellStock(companyKey, company, GameplayManager.gameplayModel.Player));
            PlusPrice.onClick.AddListener(() => currencyViewManager.InformationChange());
            PlusPrice.onClick.AddListener(() => PlusPrice.GetComponent<AudioSource>().Play());
            SaveInfo saveCurrentInfo = new SaveInfo();
            PlusPrice.onClick.AddListener(() => saveCurrentInfo.SaveModel(GameplayManager.gameplayModel));
            MinusPrice.GetComponentInChildren<TMP_Text>().text = "-" + company.PriceComponent.CurrentPrice.ToString();
            MinusPrice.onClick.AddListener(() => stockManager.BuyStock(companyKey, company, GameplayManager.gameplayModel.Player));
            MinusPrice.onClick.AddListener(() => currencyViewManager.InformationChange());
            MinusPrice.onClick.AddListener(() => saveCurrentInfo.SaveModel(GameplayManager.gameplayModel));
            MinusPrice.onClick.AddListener(() => MinusPrice.GetComponent<AudioSource>().Play());
        }
    }
}