using TMPro;
using UnityEngine;

namespace Assets.Scripts.GameplayComponents.Previews
{
    public class InfoPreview : MonoBehaviour
    {
        [field: SerializeField] public TMP_Text Name { get; private set; } = default;
        [field: SerializeField] public TMP_Text Sphere { get; private set; } = default;
        [field: SerializeField] public TMP_Text Price { get; private set; } = default;
        public void View(Company company)
        {
            Name.text = company.Name;
            Sphere.text = company.Type.ToString();
            Price.text = company.PriceComponent.CurrentPrice.ToString() + "$";
        }
    }
}
